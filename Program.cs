using System;

namespace cesarova_sifra
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "gaiusjulliusceasar";
            Console.WriteLine("původní zpráva:{0}", text);
            string zprava = "";
            int posun = 1;
            foreach (char vysledek in text)
            {
                int hodnota_ascii = (int)vysledek;
                hodnota_ascii += posun;
                if (hodnota_ascii > (int)'z')
                    hodnota_ascii -= 26;
                char znak = (char)hodnota_ascii;
                zprava += znak;
            }
            Console.WriteLine("Zašifrovaná zpráva:{0}", zprava);
            Console.ReadKey();
        }
    }
}
