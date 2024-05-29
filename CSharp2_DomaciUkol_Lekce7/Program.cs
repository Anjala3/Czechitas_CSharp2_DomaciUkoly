namespace CSharp2_DomaciUkol_Lekce7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Obdelnik obdelnicek = new Obdelnik();
            obdelnicek.Vykresli();

            Console.WriteLine();

            Trojuhelnik trojuhelnicek = new Trojuhelnik();
            trojuhelnicek.Vykresli();

            Console.WriteLine();

            Text textik = new Text();
            Console.WriteLine(textik.Text);

            Console.WriteLine();

            var seznamGrafickychObjektu = new List<GrafickyObjekt>() { obdelnicek, trojuhelnicek, textik };
            foreach (var objekt in seznamGrafickychObjektu)
            {
                objekt.Vykresli();
            }
        }
    }
}
