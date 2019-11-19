using System;

namespace artoit.PreEncjeERP
{
    public enum EPreKlientRodzajNaDok { Nabywca, Odbiorca };
    public enum EPreKlientTyp { Firma, Osoba };

    public class PreKlient
    {
        public EPreKlientTyp Typ { get; set; }

        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string NazwaPelna { get; set; }

        public string OsobaImie { get; set; }
        public string OsobaNazwisko { get; set; }

        public string NIP { get; set; }
        public string NIPUE { get; set; }

        public string Email { get; set; }
        public string Telefon { get; set; }

        public EPreKlientRodzajNaDok RodzajNaDok { get; set; }
        public string NrRachunku { get; set; }

        public bool ChceFV { get; set; }

        public PreAdres AdresGlowny { get; set; }
        
        /// <summary>
        /// Null, gdy brak
        /// </summary>
        public PreAdres AdresKoresp { get; set; }


        public PreKlient()
        {
            Typ = EPreKlientTyp.Firma;
            BudujObiekt();
        }

        public PreKlient(EPreKlientTyp typ)
        {
            Typ = typ;

            BudujObiekt();
        }

        void BudujObiekt()
        {
            Symbol = "";
            Nazwa = "";
            NazwaPelna = "";

            OsobaImie = "";
            OsobaNazwisko = "";

            NIP = "";
            NIPUE = "";

            Email = "";
            Telefon = "";

            RodzajNaDok = EPreKlientRodzajNaDok.Nabywca;
            NrRachunku = "";

            ChceFV = false;

            AdresGlowny = new PreAdres();
            AdresKoresp = null;
        }

        public bool MaPustyAdresGlowny()
        {
            try
            {
                if (AdresGlowny.Ulica == "" && AdresGlowny.Ulica == "" && AdresGlowny.Kod == "" && AdresGlowny.Miasto == "")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return true;
            }
        }
    }
}
