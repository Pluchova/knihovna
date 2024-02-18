using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knihovna
{
    internal class Navstevnik
    {
        public string Jmeno;
        public string Prijmeni;
        public int IdentifikacniCislo;
        public Kniha[] PoleZapujcenychKnih;

        public void VypujcKnihu(Kniha kniha)
        {
            for (int i = 0; i < PoleZapujcenychKnih.Length; i++)
            {
                if (PoleZapujcenychKnih[i] == null)
                {
                    PoleZapujcenychKnih[i] = kniha;
                    kniha.JeVypujcena = true;
                    Console.WriteLine($"Půjčil sis knihu {kniha.Nazev}");
                    return;
                }
            }
            Console.WriteLine("Máte maximální počet knih, které si můžete půjčit najednou");

        }
        public void NavratKnihu(Kniha kniha)
        {
            for(int i = 0; i < PoleZapujcenychKnih.Length; i++)
            {
                if (PoleZapujcenychKnih[i] == kniha)
                {
                    PoleZapujcenychKnih[i] = null;
                    kniha.JeVypujcena = false;
                    Console.WriteLine("Kniha vrácena úspěšně.");
                    return;
                }
            }
            Console.WriteLine("Tato kniha není v seznamu vašich zapůjčených knih.");
        }
    }
    
}
