using Core.Account.DTOS;
using Core.Account.Repositories;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Infrastructure.Account.Repositories;

public class EmailService : IEmailService
{
    public async Task SendEmail(EmailDto request)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse("craig.lind24@ethereal.email"));
        email.To.Add(MailboxAddress.Parse(request.To));
        email.Subject = request.Subject;
        email.Body = new TextPart(TextFormat.Html) {Text = request.Body};
        
        using var smtp = new SmtpClient();
        
        await smtp.ConnectAsync("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
        await smtp.AuthenticateAsync("craig.lind24@ethereal.email", "Y7Bzyx3qKQ3tjXzuSG");
        await smtp.SendAsync(email);
        await smtp.DisconnectAsync(true);
    }
}