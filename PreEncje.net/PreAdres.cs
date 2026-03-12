namespace artoit.PreEncjeERP
{
    public class PreAdres
    {
        public string Nazwa { get; set; } = null;
        public string Ulica { get; set; } = null;
        public string Miasto { get; set; } = null;
        public string Kod { get; set; } = null;
        public string Powiat { get; set; } = null;
        public string Wojewodztwo { get; set; } = null;
        public string Panstwo { get; set; } = null;
        public string Telefon { get; set; } = null;

        public PreAdres()
        {

        }

        public bool CzyPusty()
        {
            if (string.IsNullOrWhiteSpace(Nazwa)
                && string.IsNullOrWhiteSpace(Ulica)
                && string.IsNullOrWhiteSpace(Kod)
                && string.IsNullOrWhiteSpace(Miasto)
                && string.IsNullOrWhiteSpace(Powiat)
                && string.IsNullOrWhiteSpace(Wojewodztwo)
                && string.IsNullOrWhiteSpace(Panstwo))
                return true;
            return false;
        }
    }
}
