using System;
using System.Net.Mail;
using System.Configuration;

namespace SendReport
{
    class EmailReport
    {


       public void Enviar(string Versao_Build)     
        {
            using (var mail = new MailMessage())
            using (var smtpServer = new SmtpClient(("smtp.gmail.com")))
            {
                mail.From = new MailAddress("Email_Envio");
                mail.To.Add("Email_Destino");
                mail.Subject = "Log de execução de testes automatizados Sistema XXX - Versão: " + Versao_Build;
                mail.Body = "Olá," +
                            "\n \nUma nova execução de testes automatizados com Selenium acaba de ser realizada para o projeto XXX." +
                            "\n \nVersão:"  + Versao_Build + " -  2017  " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + 
                             "\n \nFavor baixar o arquivo e abrir no navegador para maiores detalhes." +
                            "\n \n © SheepSet Corporation";
                
                using (var attachment = new Attachment(attachPath))
                {
                    mail.Attachments.Add(attachment);
                    smtpServer.Port = 587 //25
                    smtpServer.Credentials = new System.Net.NetworkCredential("Email_Envio", "Email_Envio_Senha");
                    smtpServer.EnableSsl = false; //true
                    smtpServer.Send(mail);
                }         
                Console.WriteLine("E-mail enviado!");

            }//fim using
        }//fim metodo
    }//fim class
}//fim namespace
