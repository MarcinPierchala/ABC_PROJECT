using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_1
{
    public class ObslugaStringa
    {
        public string WstawSpacje(string zrodlo)
        {
            string wynik = string.Empty;


            if (!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach(var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        wynik = wynik.Trim();
                        wynik += " ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim();
            }
            return wynik;
        }
    }
}
