namespace ABC.BL
{
    public class Klient
    {
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

        public bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;
            if (string.IsNullOrWhiteSpace(Email))
                poprawne |= false;

            return poprawne;
        }

    }
}