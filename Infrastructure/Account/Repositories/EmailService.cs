using Core.Account.DTOS;
using Core.Account.Repositories;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Infrastructure.Account.Repositories;

public class EmailService : IEmailService
{
    public void SendEmail(EmailDto request)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse("verlie.runte45@ethereal.email"));
        email.To.Add(MailboxAddress.Parse(request.To));
        email.Subject = request.Subject;
        email.Body = new TextPart(TextFormat.Html) {Text = request.Body};
        
        using var smtp = new SmtpClient();
        
        smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
        smtp.Authenticate("verlie.runte45@ethereal.email", "TjVmGv1up9zgH8KEjB");
        smtp.Send(email);
        smtp.Disconnect(true);
    }
}