using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    public class ToDoSenderEmail
    {
        private readonly string[] Emails = { "aleksstanov84@gmail.com", "amilish82@gmail.com" };

        private readonly string FromEmail = "todo_aleks@example.com";

        private readonly string FromPassword = "Saa16061984";

        public ToDoSenderEmail() { }

        public bool SendEmail(string subject, string body)
        {
            try
            {
                foreach (string email in Emails)
                {
                    if (!string.IsNullOrWhiteSpace(email)) // Fix: Check if the email string is not null or empty
                    {
                        string fromEmail = FromEmail;
                        string fromPassword = FromPassword;
                        string toEmail = email; // Fix: Corrected variable name from 'Email' to 'email'

                        MailMessage message = new()
                        {
                            From = new MailAddress(fromEmail)
                        };

                        message.To.Add(toEmail);
                        message.Subject = subject;
                        message.Body = body;

                        SmtpClient client = new("smtp.gmail.com", 587)
                        {
                            Credentials = new NetworkCredential(fromEmail, fromPassword),
                            EnableSsl = true
                        };

                        client.Send(message);
                        Console.WriteLine($"Sending email to {toEmail} with subject: {subject}");
                        Console.WriteLine($"Body: {body}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid email address: " + email);
                        throw new ToDoException("Error: Invalid email address: " + email);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ToDoException("Error sending email:\n" + ex.Message);
            }
            return true;
        }
    }
}
