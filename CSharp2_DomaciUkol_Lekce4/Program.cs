﻿namespace CSharp2_DomaciUkol_Lekce4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

            DateTime aktualniDatumACas = DateTime.Now;
            Console.WriteLine($"Dnes je: {aktualniDatumACas}");

            Console.WriteLine();


            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

            DateTime mojeDatumNarozeni = new DateTime(1989, 09, 20);
            TimeSpan jakJsemStara = aktualniDatumACas - mojeDatumNarozeni;
            Console.WriteLine($"Od meho narozeni ubehlo: {jakJsemStara.TotalDays} dnů.");

            Console.WriteLine();


            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

            List<string> seznamOvoce = new List<string> { "hruska", "mango", "banan", "jahoda" };
            foreach (string s in seznamOvoce)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            // 4. Smaž z tohoto listu libovolnou hodnotu.

            seznamOvoce.Remove("hruska");
            foreach (string s in seznamOvoce)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

            bool obsahujeFenykl = seznamOvoce.Contains("Fenykl");
            Console.WriteLine($"Obsahuje muj seznam ovoce Fenykl? Odpoved:{obsahujeFenykl}.");

            Console.WriteLine();

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").


            foreach (string s in seznamOvoce)
            {
                Console.WriteLine($"{seznamOvoce.IndexOf(s)}." + s);
            }

            Console.WriteLine();

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

            Dictionary<string, int> cenaNakupu = new Dictionary<string, int>
            {
                { "chleba", 20 },
                { "maslo", 55 },
                { "mleko", 32 },
                { "rohlik", 4 }

            };

            foreach (var item in cenaNakupu)
            {
                Console.WriteLine($"Polozka: {item.Key} stoji {item.Value} Kc.");
            }
            Console.WriteLine();

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

            string hledanaPolozka = "maslo";
            bool obsahujePolozku = cenaNakupu.ContainsKey(hledanaPolozka);

            if (obsahujePolozku)
            {
                Console.WriteLine($"Seznam obsahuje polozku {hledanaPolozka}, ktera stoji {cenaNakupu["maslo"]}");
            }
            else
            {
                Console.WriteLine($"Seznam {hledanaPolozka} neobsahuje.");
            }

            Console.WriteLine();
        }

    }
}
