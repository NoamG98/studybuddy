using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using StudyBuddyAPI.Data;
using StudyBuddyAPI.Models;
using StudyBuddyAPI.Services;
using System.Text;
using DotNetEnv; // Load environment variables

// Load environment variables
Env.Load();
Console.WriteLine("Environment variables loaded.");

// Fetch JWT settings from environment variables
var secretKey = Environment.GetEnvironmentVariable("JWT_SECRET") ?? "FallbackSecretKey";
var issuer = Environment.GetEnvironmentVariable("JWT_ISSUER") ?? "https://localhost:5000";
var audience = Environment.GetEnvironmentVariable("JWT_AUDIENCE") ?? "https://localhost:3000";

var builder = WebApplication.CreateBuilder(args);

// Add DbContext with SQL Server
builder.Services.AddDbContext<StudyBuddyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add CORS Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyMethod()
              .AllowAnyHeader()
              .SetIsOriginAllowed(origin => true)
              .AllowCredentials(); // Ensure credentials are allowed
    });
});

// Add JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = issuer,
            ValidAudience = audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
        };
        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                // Extract JWT from Authorization header
                var accessToken = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                if (!string.IsNullOrEmpty(accessToken))
                {
                    context.Token = accessToken;
                }
                return Task.CompletedTask;
            }
        };
    });

// Add email service
builder.Services.AddScoped<EmailService>();

// Add controllers with NewtonsoftJson to handle JSON serialization
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Use Swagger in Development mode
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable CORS
app.UseCors("AllowAll");

// Use HTTPS redirection and Authentication/Authorization middleware
app.UseHttpsRedirection();
app.UseAuthentication(); // Authentication middleware
app.UseAuthorization();
app.MapControllers();

// Seed StudyFields from JSON file
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<StudyBuddyDbContext>();

    if (!context.StudyFields.Any())
    {
        try
        {
            string jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", "studyfields.json");

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                var studyFields = System.Text.Json.JsonSerializer.Deserialize<List<StudyField>>(json);

                if (studyFields != null && studyFields.Any())
                {
                    context.StudyFields.AddRange(studyFields);
                    context.SaveChanges();
                    Console.WriteLine("Study fields successfully seeded to the database.");
                }
            }
            else
            {
                Console.WriteLine($"JSON file not found at path: {jsonFilePath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading study fields: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("StudyFields table already contains data.");
    }
}

app.Run();
