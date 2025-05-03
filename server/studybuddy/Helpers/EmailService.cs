using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Net;
using System.Net.Mail;

namespace StudyBuddy.Helpers
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;
        private readonly IHostEnvironment _environment;

        public EmailService(IConfiguration configuration, IHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public void SendEmail(string toEmail, string subject, string body)
        {

            if (_environment.IsDevelopment())
            {

                Console.WriteLine($"[DEBUG] Skipping email to {toEmail} in Development");
                return;
            }

            var smtpClient = new SmtpClient(_configuration["EmailSettings:SmtpServer"])
            {
                Port = int.Parse(_configuration["EmailSettings:Port"]!),
                Credentials = new NetworkCredential(
                                      _configuration["EmailSettings:Username"]!,
                                      _configuration["EmailSettings:Password"]!),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_configuration["EmailSettings:From"]!),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(toEmail);

            smtpClient.Send(mailMessage);
        }
    }
}
