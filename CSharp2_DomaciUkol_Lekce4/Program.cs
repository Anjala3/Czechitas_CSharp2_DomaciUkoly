namespace CSharp2_DomaciUkol_Lekce4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

            DateTime aktualniDatumACas = DateTime.Now;
            Console.WriteLine($"Dnes je: {aktualniDatumACas}");

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

            DateTime mojeDatumNarozeni = new DateTime(1989, 09, 20);
            TimeSpan jakJsemStara = aktualniDatumACas - mojeDatumNarozeni;
            Console.WriteLine($"Od meho narozeni ubehlo: {jakJsemStara.TotalDays} dnů.");

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

            List<string> seznamOvoce = new List<string> { "hruska", "mango", "banan", "jahoda" };

            // 4. Smaž z tohoto listu libovolnou hodnotu.

            seznamOvoce.Remove("hruska");
            foreach (string s in seznamOvoce)
            {
                Console.WriteLine(s);
            }


        }
    }
}
