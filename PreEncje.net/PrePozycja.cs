using System.Xml.Serialization;

namespace artoit.PreEncjeERP
{
    public class PrePozycja
    {
        public PreTowar Towar { get; set; } = new PreTowar();

        public bool UslugaJednorazowa { get; set; } = false;
        public string UslugaJednorazowaNazwa { get; set; } = null;
        public string UslugaJednorazowaOpis { get; set; } = null;
        public string UslugaJednorazowaPKWiU { get; set; } = null;

        public decimal? RabatProcent { get; set; } = null;
        public decimal? CenaNettoPrzedRabatem { get; set; } = null;
        public decimal? CenaNettoPoRabacie { get; set; } = null;
        public decimal? CenaBruttoPrzedRabatem { get; set; } = null;
        public decimal? CenaBruttoPoRabacie { get; set; } = null;

        public decimal Ilosc { get; set; } = 1;
        public decimal? Vat { get; set; } = null;
        public string JM { get; set; } = "szt.";
        public string VatSymbol { get; set; } = null;
        public string OpisPozycji { get; set; } = null;
        public string KodDostawy { get; set; } = null;

        public decimal? WartoscCalejPozycjiNettoZRabatem { get; set; } = null;
        public decimal? WartoscCalejPozycjiBruttoZRabatem { get; set; } = null;
        public decimal? WartoscCalejPozycjiNetto { get; set; } = null;
        public decimal? WartoscCalejPozycjiBrutto { get; set; } = null;

        public PrePozycja()
        {

        }

        public PrePozycja(PreTowar towar, decimal ilosc = 1)
        {
            Towar = towar;
            Ilosc = ilosc;
        }
    }
}
