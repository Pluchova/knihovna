using System;

namespace knihovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knihovna knihovna = new Knihovna(100, 100);

            Autor autor = new Autor("Karel", "Čapek", 1890);

            Kniha kniha = new Kniha("R.U.R.", autor, 1920, false);
            Kniha kniha2 = new Kniha("Bílá nemoc", autor, 1937, false);

            knihovna.PridejKnihu(kniha);

            Navstevnik navstevnik = new Navstevnik("Jan", "Novák", 12345);
            navstevnik.PoleZapujcenychKnih = new Kniha[5];

            knihovna.PridejNavstevnika(navstevnik);

            knihovna.VypujcKnihu(navstevnik, kniha);
            knihovna.VypujcKnihu(navstevnik, kniha2);
            navstevnik.VypisVypujceneKnihy();
            knihovna.NavratKnihu(navstevnik, kniha);
            navstevnik.VypisVypujceneKnihy();
        }
    }
}