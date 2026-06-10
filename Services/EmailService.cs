using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace RusdiBakery.Services
{
    public static class EmailService
    {
        private static readonly string SmtpServer = Environment.GetEnvironmentVariable("RUSDI_SMTP_SERVER") ?? "smtp.gmail.com";
        private static readonly int SmtpPort = int.TryParse(Environment.GetEnvironmentVariable("RUSDI_SMTP_PORT"), out var port) ? port : 587;
        private static readonly string SenderEmail = Environment.GetEnvironmentVariable("RUSDI_SMTP_EMAIL") ?? "khrllhmrintj@gmail.com";
        private static readonly string SenderPassword = Environment.GetEnvironmentVariable("RUSDI_SMTP_PASSWORD") ?? "ajyu abvd ecot zqnd";

        public static async Task SendTemporaryPasswordAsync(string recipientEmail, string tempPassword)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SenderPassword))
                {
                    throw new InvalidOperationException("SMTP password is not configured. Set RUSDI_SMTP_PASSWORD to a valid Gmail App Password.");
                }

                var message = new MailMessage();
                message.From = new MailAddress(SenderEmail, "Rusdi Bakery Admin");
                message.To.Add(new MailAddress(recipientEmail));
                message.Subject = "Rusdi Bakery - Admin Password Reset";
                message.Body = $@"
                    <h3>Password Reset Request</h3>
                    <p>We received a request to reset your admin password.</p>
                    <p>Your temporary password is: <b>{tempPassword}</b></p>
                    <p>Please login and change your password immediately.</p>
                    <br/>
                    <p>Best regards,<br/>Rusdi Bakery Team</p>";
                message.IsBodyHtml = true;

                using var client = new SmtpClient(SmtpServer, SmtpPort);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(SenderEmail, SenderPassword);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                await client.SendMailAsync(message);
            }
            catch (SmtpException ex) when (ex.Message.Contains("5.7.0") || ex.Message.Contains("Authentication Required", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("SMTP authentication failed. For Gmail, use a 16-character App Password in RUSDI_SMTP_PASSWORD, not the normal Gmail account password.", ex);
            }
            catch (Exception ex)
            {
                // Re-throw to be handled by the UI
                throw new Exception($"Failed to send email: {ex.Message}", ex);
            }
        }
    }
}
