namespace PrimaAPP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Tabelline!");
                Console.WriteLine("Per salvare sul disco la tua tabellina usa il seguente schema");
                Console.WriteLine("applicazione.exe [tabellina] [ripetizioni]");
                Console.WriteLine("es.: applicazione.exe 2 10");
            }
            else
            {
                try
                {
                    int tabellina = int.Parse(args[0]);
                    int ripetizioni = int.Parse(args[1]);
                    string filePath = $"tabellina_{tabellina}.txt";
                    for (int i = 0; i <= ripetizioni; i++)
                    {
                        int risultato = tabellina * i;
                        Console.WriteLine($"{tabellina} x {i} = {risultato}");
                        File.AppendAllText(filePath, $"{tabellina} X {i} = {risultato}\n");
                    }
                }
                catch
                {
                    Console.WriteLine("ricorda di immettere due parametri numerici");
                }
            }
        }
    }
}