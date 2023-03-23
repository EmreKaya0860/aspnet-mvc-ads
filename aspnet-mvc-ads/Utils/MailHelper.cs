using System.Net.Mail;
using System.Net;
using App.Data.Entity;

namespace aspnet_mvc_ads.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(User user)
        {
            SmtpClient smtpClient = new SmtpClient("mail.siteadresi.com", 587); 
            smtpClient.Credentials = new NetworkCredential("email kullanıcı adı(info@siteadi.com)", "email şifre");
            smtpClient.EnableSsl = true; 
            MailMessage message = new MailMessage();
            message.From = new MailAddress("info@siteadi.com");
            message.To.Add("mailingonderilecegiadres@gmail.com");
            message.Subject = "Siteden Uyarı Mesaj Geldi";
            message.Body = $"<h1>Mail Bilgileri</h1> İsim : {user.Name} <hr /> Email : {user.Email} <hr /> Telefon : {user.Phone}";
            message.IsBodyHtml = true;
            smtpClient.Send(message);
            await smtpClient.SendMailAsync(message);
            smtpClient.Dispose();
        }
    }
}
