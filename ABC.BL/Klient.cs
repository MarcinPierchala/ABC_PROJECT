using Common_1;

namespace ABC.BL
{
    public class Klient : BaseClass, ILogowanie
    {
        public Klient() : this(0)
        {

        }

        public Klient(int klientId)
        {
            KlientId = klientId;
            AdresList = new List<Adres>();
        }

        public List<Adres> AdresList { get; set; }

        public static int Counter { get; set; }

        private string _nazwisko;
        
        public string Nazwisko
        {
            get 
            { 
                return _nazwisko; 
            }
            set 
            { 
                //if (string.IsNullOrWhiteSpace(value))
                    _nazwisko = value; 
            }
        }

        public string Imie { get; set; }

        public string Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko 
        { 
            get 
            {
                string imieNazwisko = Imie;
                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko; 
            } 
        }

        public int KlientTyp { get; set; }

        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;
            if (string.IsNullOrWhiteSpace(Email))
                poprawne = false;

            return poprawne;
        }

        public bool Zapisz()
        {
            return true;
        }

        public Klient Pobierz(int klientId)
        {
            return new Klient();
        }

        public List<Klient> Pobierz()
        {
            return new List<Klient>();
        }

        public override string ToString()
        {
            return ImieNazwisko;
        }

        public string Log()
        {
            var logTekst = KlientId + ": " +
                ImieNazwisko + ", " +
                "Email: " + Email + ", " +
                "Status: " + StanObiektu.ToString();

            return logTekst;
        }

    }
}