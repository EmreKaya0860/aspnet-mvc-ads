using System.Net.Mail;

namespace aspnet_mvc_ads.Utils
{
    public class ResetPassword
    {
        public static void PasswordSendMail(string link)

        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            mail.From = new MailAddress("advertsite@gmail.com");
            mail.To.Add("burcustael@gmail.com");
            mail.Subject = "Sifre güncellene talebi";
            mail.Body = "<h2>Şifrenizi yenileaek için Linke tiklayin </h2>";
            mail.Body += $"<a href= '{link}' 1.> Şifre yenileme baglantısı";
            mail.IsBodyHtml = true;
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("burcustael@gmail.com", "123");
            smtp.Send(mail);

        }
    }

}