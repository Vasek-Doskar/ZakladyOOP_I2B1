namespace ZakladyOOP_I2B1
{
    public class Clovek
    {
        //fields (Atributy)
        private string _jmeno;
        private int _vek;
        private string _prijmeni;

        // properties (Vlastnosti)
        public string Jmeno
        {
            get
            {
                return _jmeno;
            }
            set
            {
                if (_jmeno != value && value.Length >= 3)
                {
                    _jmeno = value;
                }
            }
        }

        public string Prijmeni
        {
            get
            {
                return _prijmeni;
            }
            set
            {
                if (_prijmeni != value && value.Length >= 3)
                {
                    _prijmeni = value;
                }
            }
        }

        public int Vek
        {
            get
            {
                return _vek;
            }
            set
            {
                value = Math.Abs(value);
                if (value > 110)
                    throw new Exception($"Tento věk není ({value}) možný!");
                else
                    _vek = value;
            }
        }

        public Clovek(string jmeno, string prijmeni, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
        }
        #region MyRegion

        public string Pozdrav() =>
            $"Jsem {_jmeno} {Prijmeni}, a je mi {_vek}let";

        public string Pozdrav(string pozdrav)
        {
            return $"{pozdrav}! " + Pozdrav();
        }

        public string Pozdrav(string pozdrav, string koho)
        {
            return $"{pozdrav} {koho}!" + Pozdrav();
        }

        public string Pozdrav(string text, Clovek kdo)
        {
            return $"{text} {kdo.Jmeno} {kdo.Prijmeni}! " + Pozdrav() +$"\n{kdo.Pozdrav("Ahoj")}";
        }

        #endregion


    }
}
