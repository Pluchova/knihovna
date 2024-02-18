using System;

namespace knihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knihovna knihovna = new Knihovna();
            knihovna.PoleKnih = new Kniha[100];
            knihovna.PoleNavstevniku = new Navstevnik[100];

            Autor autor = new Autor();
            autor.Jmeno = "Karel";
            autor.Prijmeni = "Čapek";
            autor.RokNarozeni = 1890;


            Kniha kniha = new Kniha();

            kniha.Nazev = "R.U.R.";
            kniha.Autor = $"{autor.Jmeno} {autor.Prijmeni}";
            kniha.RokVydani = 1920;
            kniha.JeVypujcena = false;
            Kniha kniha2 = new Kniha();

            kniha2.Nazev = "Bílá nemoc";
            kniha2.Autor = $"{autor.Jmeno} {autor.Prijmeni}";
            kniha2.RokVydani = 1937;
            kniha2.JeVypujcena = false;


            knihovna.PridejKnihu(kniha);

            Navstevnik navstevnik = new Navstevnik();
            navstevnik.Jmeno = "Jan";
            navstevnik.Prijmeni = "Novák";
            navstevnik.PoleZapujcenychKnih = new Kniha[5]; 


            knihovna.PridejNavstevnika(navstevnik);

            navstevnik.VypujcKnihu(kniha);
            navstevnik.VypujcKnihu(kniha2);
            Console.WriteLine($"Máš vypůjčené knihy:");
            foreach (Kniha pujcenaKniha in navstevnik.PoleZapujcenychKnih)
            {
                if (pujcenaKniha != null)
                {
                    Console.WriteLine($"- {pujcenaKniha.Nazev}, rok vydání: {pujcenaKniha.RokVydani}");
                }
            }

            navstevnik.NavratKnihu(kniha);
            Console.WriteLine($"Máš vypůjčené knihy:");
            foreach (Kniha pujcenaKniha in navstevnik.PoleZapujcenychKnih)
            {
                if (pujcenaKniha != null)
                {
                    Console.WriteLine($"- {pujcenaKniha.Nazev}, rok vydání: {pujcenaKniha.RokVydani}");
                }
            }
        }
    }
}