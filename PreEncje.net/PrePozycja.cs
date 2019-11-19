using System.Xml.Serialization;

namespace artoit.PreEncjeERP
{
    public class PrePozycja
    {
        public PreTowar Towar { get; set; }

        public decimal RabatProcent { get; set; }
        public decimal CenaNettoPrzedRabatem { get; set; }
        public decimal CenaNettoPoRabacie { get; set; }
        public decimal CenaBruttoPrzedRabatem { get; set; }
        public decimal CenaBruttoPoRabacie { get; set; }
        public decimal Ilosc { get; set; }
        public decimal? Vat { get; set; }
        public string JM { get; set; }

        [XmlIgnoreAttribute]
        public string VatSymbol { get; set; } = null;
        public string OpisPozycji { get; set; }
        public string KodDostawy { get; set; }
        public decimal WartoscCalejPozycjiNettoZRabatem { get; set; }
        public decimal WartoscCalejPozycjiBruttoZRabatem { get; set; }
        public decimal WartoscCalejPozycjiNetto { get; set; }
        public decimal WartoscCalejPozycjiBrutto { get; set; }

        public PrePozycja()
        {
            Towar = new PreTowar();

            RabatProcent = 0;
            CenaNettoPrzedRabatem = -1;
            CenaNettoPoRabacie = -1;
            CenaBruttoPrzedRabatem = -1;
            CenaBruttoPoRabacie = -1;
            Ilosc = 0;
            OpisPozycji = "";
            KodDostawy = "";
            Vat = null;
            JM = null;
            WartoscCalejPozycjiNettoZRabatem = -1;
            WartoscCalejPozycjiBruttoZRabatem = -1;
            WartoscCalejPozycjiNetto = -1;
            WartoscCalejPozycjiBrutto = -1;
        }
    }
}
