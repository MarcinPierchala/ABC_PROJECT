using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class WyswietanieZamowienia
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTimeOffset? DataZamowienia { get; set; }
        public List<WyswPozycjiZam> WyswPozycjiZamLista { get; set; }
        public int ZamowienieId { get; set; }
        public Adres AdresDostawy { get; set; }

    }
}
