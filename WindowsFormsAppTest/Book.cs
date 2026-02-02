using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest
{
    public class Book
    {
        public string Naslov {  get; set; }
        public string Autor { get; set; }   
        public int Godina { get; set; }
        public string Zanr { get; set; }
        public int BrojStranica { get; set; }
        public bool Dostupna { get; set; }

        public override string ToString()
        {
            return $"{Naslov}|{Autor}|{Godina}|{Zanr}|{BrojStranica}|{Dostupna}";
        }

    }
}
