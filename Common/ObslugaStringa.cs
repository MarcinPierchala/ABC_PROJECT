namespace Common
{
    public class ObslugaStringa
    {
        public string InsertSpace(string zrodlo)
        {
            string wynik = string.Empty;

            if (!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        wynik += " ";
                    }

                    wynik += litera;
                }
            }

            return wynik;
        }
    }
}