using System.IO;
using System;
using System.Net;
using System.Net.Mail;
internal class Program
{
    private static void Main(string[] args)
    {
        string rootFolder = "C:\\testITS";

        /*
        SmtpClient client = new SmtpClient("Smtp.gmail.com",587);
        MailMessage messaggio = new MailMessage("io@posta.it","tu@posta.it","messaggio","corpo");
        client.Send(messaggio);
        */

        HttpListener server = new HttpListener();
        server.Prefixes.Add("http://localhost:8080/");
        server.Prefixes.Add("https://localhost:8081/");
        server.Start();
        Console.WriteLine("Server in ascolto...");
        while (true)
        {
            // attendo una chiamata
            HttpListenerContext chiamata = server.GetContext();
            // leggo la richiesta
            HttpListenerRequest cassa = chiamata.Request;
            Console.WriteLine($"Chiamata in ingresso per {cassa.RawUrl}");
            // decido cosa dire
            // capendo se il file esiste
            string pathLocale = rootFolder + cassa.RawUrl.Replace("/", "\\");
            string risposta = "";
            if (File.Exists(pathLocale))
            {
                // e se esiste caricando il suo contenuto nella risposta da inviare
                risposta = File.ReadAllText(pathLocale);
            }
            else
            {
                if (pathLocale.EndsWith(".css"))
                {
                    risposta = @"body { 
                                    background-color: #eeeeee;
                                    font-family: sans-serif;
                                }
                                ";
                }
                else if (pathLocale.EndsWith("\\") && Directory.Exists(pathLocale))
                {
                    string[] files = Directory.GetFiles(pathLocale);
                    string links = "";
                    foreach (string file in files)
                    {
                        string url = file.Replace(pathLocale, "");
                        links += $"<li><a href='{url}'>{url}</a></li>";
                    }
                    risposta = $@"<html>
                                       <head>
                                           <link rel=""stylesheet"" type=""text/css"" href=""stile.css"">
                                       </head>
                                       <body>
                                           <h1>{cassa.RawUrl}</h1>
                                           <ul>{links}</ul>
                                       </body>
                                   </html>";
                }
                else
                {
                    // se non esiste lo avviso
                    risposta = $"Il file {pathLocale} non esiste";
                }
            }
            // lo converto in impulsi
            byte[] impulsi = System.Text.Encoding.UTF8.GetBytes(risposta);
            Console.WriteLine("messaggio convertito in impulsi");
            // prendo il microsofono per parlare
            HttpListenerResponse microfono = chiamata.Response;
            microfono.ContentType = "text/html";
            // e lo spedisco al mio interlocutore
            microfono.OutputStream.Write(impulsi, 0, impulsi.Length);
            // prima di riagganciare il telefono
            microfono.OutputStream.Close();
        }
    }
}
