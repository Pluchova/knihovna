using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knihovna
{
    public class Autor
    {
        public string Jmeno;
        public string Prijmeni;
        public int RokNarozeni;

        public Autor(string jmeno, string prijmeni, int rokNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RokNarozeni = rokNarozeni;
        }
    }
}
