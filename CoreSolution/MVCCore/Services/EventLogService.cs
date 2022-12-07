using Microsoft.AspNetCore.Html;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace MVCCore.Services
{
    public class EventLogService : IEventLogService
    {
        public void Log(string message, NiveauAlerte alerte)
        {
            try
            {
                switch (alerte)
                {
                    case NiveauAlerte.Information:
                        EventLog.WriteEntry("Application", message, EventLogEntryType.Information);
                        break;
                    case NiveauAlerte.Avertissement:
                        EventLog.WriteEntry("Application", message, EventLogEntryType.Warning);
                        sendmail(message);
                        break;
                    case NiveauAlerte.Erreur:
                        EventLog.WriteEntry("Application", message, EventLogEntryType.Error);
                        sendmail(message);
                        break;
                    default:
                        throw new ArgumentException("Verifier les paramètres");
                }
            }
            catch (ArgumentException erreur)
            {
                Debug.WriteLine(erreur.Message);
            }
        }

        private void sendmail(string messageBody)
        {
            var date = DateTime.Now;
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("me780411@gmail.com");
                message.To.Add(new MailAddress("me780411@gmail.com"));
                message.Subject = $"Alerte de l'application {date.Day}/{date.Month}/{date.Year}";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = $"Alerte de l'application {date.Day}/{date.Month}/{date.Year} " +
                    $"{date.Hour}/{date.Minute}\n Message: " + messageBody;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;

                #region secret
                smtp.Credentials = new NetworkCredential("me780411@gmail.com", "");
                #endregion

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                
                smtp.Send(message);
            }
            catch (Exception) { }
        }
    }
}

namespace MVCCore
{
    public enum NiveauAlerte
    {
        Information, Avertissement,Erreur
    }
}