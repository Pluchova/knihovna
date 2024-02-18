using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knihovna
{
    internal class Knihovna
    {
        public Kniha[] PoleKnih;
        public Navstevnik[] PoleNavstevniku;
        private int posledniIndexKnih;
        private int posledniIndexNavstevniku;

        public void PridejKnihu(Kniha kniha)
        {
            if (posledniIndexKnih < PoleKnih.Length)
            {
                PoleKnih[posledniIndexKnih] = kniha;
                posledniIndexKnih++;
            }
            else
                Console.WriteLine("Knihovna je plná.");
        }
        public void PridejNavstevnika(Navstevnik navstevnik)
        {
            if (posledniIndexNavstevniku < PoleNavstevniku.Length)
            {
                PoleNavstevniku[posledniIndexNavstevniku] = navstevnik;
                posledniIndexNavstevniku++; 
            }
            else
                Console.WriteLine("Knihovna má moc návštěvníků.");
        }




    }
}

