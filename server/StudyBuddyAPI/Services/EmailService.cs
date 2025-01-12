using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace StudyBuddyAPI.Services
{
    /// <summary>
    /// Service for sending emails to users.
    /// </summary>
    public class EmailService
    {
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587;

        // TODO: Replace with environment variables for better security
        private const string SenderEmail = "your-email@gmail.com"; // Change to your email
        private const string SenderPassword = "your-email-password"; // Change to your email password

        /// <summary>
        /// Sends a welcome email to the specified recipient.
        /// </summary>
        /// <param name="recipientEmail">The email address of the recipient.</param>
        public async Task SendWelcomeEmail(string recipientEmail)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(SenderEmail),
                Subject = "Welcome to StudyBuddy!",
                Body = @"
                    <h1>Welcome to StudyBuddy</h1>
                    <p>The social network for students!</p>
                    <a href='http://localhost:3004/login' style='background: #007bff; color: white; padding: 10px 20px; text-decoration: none; border-radius: 5px;'>Log in</a>
                ",
                IsBodyHtml = true
            };

            mailMessage.To.Add(recipientEmail);

            using (var smtpClient = new SmtpClient(SmtpServer, SmtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(SenderEmail, SenderPassword);
                smtpClient.EnableSsl = true;

                try
                {
                    await smtpClient.SendMailAsync(mailMessage);
                    Console.WriteLine("Welcome email sent successfully to {0}", recipientEmail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error sending email: {0}", ex.Message);
                    throw;
                }
            }
        }
    }
}
