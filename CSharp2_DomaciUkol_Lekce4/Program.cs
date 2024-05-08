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

        }
    }
}
