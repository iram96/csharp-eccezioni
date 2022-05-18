// See https://aka.ms/new-console-template for more information

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int EseguiDivisione(int a, int b)
        {
            return a / b;
        }

        private static string hello(string name)
        {

            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return "Hello " + name;

        }

        static void Main(string[] args)
        {

            try
            {

                string MioNome = null;
                string sAppo;
                sAppo = hello(MioNome);


                //Eccezione NULLREFERENCE

                string text = null;
                int length = text.Length;
                Console.WriteLine(length);
                Console.ReadLine();



                //Un esempio di codice che genera eccezione (dividendo 0   oppure stringa non intero in input)
                Console.WriteLine("Inserisci il divisore:");
                string a = Console.ReadLine();
                Console.WriteLine("Inserisci il dividendo:");
                string b = Console.ReadLine();

                int iDivisore = Convert.ToInt32(a);
                int iDividendo = Convert.ToInt32(b);

                int iRes = EseguiDivisione(iDivisore, iDividendo);
                Console.WriteLine($"Risultato della divisione: {iRes}");

            }

            catch (Exception ex)
            {
                // Codice da eseguire in caso di eccezione.
                Console.WriteLine("È avvenuta la seguente eccezione: {0}", ex.Message);
                // Proprietà interessanti nella gestione dell'eccezione.
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
                //StackTrace:
                //mi dice la chiamata interna che sta facendo e dov'è l'errore
            }

            /*int d = 1; int c = 5;
            try
            {
                var a = 1;
                d = a - 1;
                c = a / d;
                a = a / c;
            }
            catch (DivideByZeroException dEx) when (d == 0)
            {
                // we're throwing the same kind of exception
                throw new DivideByZeroException("Cannot divide by d because it is zero", dEx);
            }
            catch (DivideByZeroException dEx) when (c == 0)
            {
                // we're throwing the same kind of exception
                throw new DivideByZeroException("Cannot divide by c because it is zero", dEx);
            }
            */
        }
    }
}