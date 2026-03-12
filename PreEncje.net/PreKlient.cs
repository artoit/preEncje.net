using System;
using System.Text.RegularExpressions;

namespace artoit.PreEncjeERP
{
    public enum EPreKlientRodzajNaDok { Nabywca, Odbiorca };
    public enum EPreKlientTyp { Firma, Osoba };

    public class PreKlient
    {
        public EPreKlientTyp Typ { get; set; } = EPreKlientTyp.Firma;
        public EPreKlientRodzajNaDok RodzajNaDok { get; set; } = EPreKlientRodzajNaDok.Nabywca;

        // nie działa w sferze public bool CzyJednorazowy { get; set; } = false;

        public string Symbol { get; set; } = null;
        public string Nazwa { get; set; } = null;
        public string NazwaPelna { get; set; } = null;

        public string OsobaImie { get; set; } = null;
        public string OsobaNazwisko { get; set; } = null;

        public string OsobaPESEL { get; set; } = null;

        public string NIP { get; set; } = null;
        public string NIPUE { get; set; } = null;

        public string REGON { get; set; }

        public string Email { get; set; } = null;
        public string Telefon { get; set; } = null;


        /// <summary>
        /// Można wpisać łącznie z nazwą, czyli np.: "Bank ABC 01 1234 1234 0421 0421", ale też sam numer: "12 1234 8543 5313 5123" (może też być bez spacji)
        /// </summary>
        public string NrRachunku { get; set; } = null;

        public bool? ChceFV { get; set; } = null;

        public bool? ZgodaNewsletter { get; set; } = null;

        public PreAdres AdresGlowny { get; set; } = new PreAdres();

        public PreAdres AdresKoresp { get; set; } = new PreAdres();

        public string NipCzysty
        {
            get
            {
                string nipStr = NIP.Trim().Replace("-", "").Replace(" ", "");
                Regex regex = new Regex("[a-zA-Z]");
                string bezLiter = regex.Replace(nipStr, "");
                return bezLiter;
            }
        }

        public PreKlient()
        {

        }

        public PreKlient(EPreKlientTyp typ)
        {
            Typ = typ;
        }
    }
}
