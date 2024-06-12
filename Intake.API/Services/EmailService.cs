using System.Net.Mail;
using System.Net;

public class EmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string[] toEmails, string subject, string body)
    {
        var smtpClient = new SmtpClient(_configuration["Smtp:Host"])
        {
            Port = int.Parse(_configuration["Smtp:Port"]),
            Credentials = new NetworkCredential(_configuration["Smtp:Username"], _configuration["Smtp:Password"]),
            EnableSsl = bool.Parse(_configuration["Smtp:EnableSsl"])
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress(_configuration["Smtp:From"]),
            Subject = subject,
            Body = body,
            IsBodyHtml = true,
        };

        foreach (var toEmail in toEmails)
        {
            mailMessage.To.Add(toEmail);
        }

        await smtpClient.SendMailAsync(mailMessage);
    }
}
