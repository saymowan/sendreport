using System;

namespace SendReport
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args == null || args.Length != 2)
            {
                Console.WriteLine("Número inválido de argumentos. Favor inserir somente a versão da build da aplicação e o anexo.");
                return;
            }

            try {
                var report = new EmailReport();
                report.Enviar(args[0],args[1]); 
                //report.Enviar();
            }
            catch { 
                Console.WriteLine("Erro no envio do e-mail.");
            }
        }// fim Main
    }// fim Class
}// fim Namespace