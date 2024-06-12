using System.Globalization;

namespace StringFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kwota = 17.75;
            Console.WriteLine(kwota.ToString("C"));

            string napis = $"{kwota:c}";
            Console.WriteLine(napis);

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("dd MMMM yyyy"));

            string myString = "wAr aNd pEaCe";
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
        }
    }
}
