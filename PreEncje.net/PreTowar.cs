using System.Collections.Generic;

namespace artoit.PreEncjeERP
{
    public enum ERodzajCenyTowaru { Kartotekowa, SprzedazyNetto, SprzedazyBrutto };
    public enum ERodzajTowaru { Towar, Usluga, Komplet, Opakowanie };

    public class PreTowar
    {
        public ERodzajTowaru Rodzaj { get; set; } = ERodzajTowaru.Towar;

        public string Symbol { get; set; } = null;
        public string SymbolDostawcy { get; set; } = null;
        public string NazwaDostawcy { get; set; } = null;
        public string SymbolProducenta { get; set; } = null;
        public string NazwaProducenta { get; set; } = null;
        public string Nazwa { get; set; } = null;
        public decimal? CenaKartotekowaNetto { get; set; } = null;
        public decimal? CenaNetto { get; set; } = null;
        public decimal? CenaBrutto { get; set; } = null;
        public string JM { get; set; } = "szt.";
        public string KodKreskowy { get; set; } = null;
        public string Vat { get; set; } = null;
        public string PKWiU { get; set; } = null;
        public string Opis { get; set; } = null;
        public string OpisPelny { get; set; } = null;
        public string Uwagi { get; set; } = null;
        public string AdresWWW { get; set; } = null;

        public string KodCN { get; set; } = null;
        public string KodGTU { get; set; } = null;

        public decimal? Wysokosc { get; set; } = null;
        public decimal? Dlugosc { get; set; } = null;
        public decimal? Szerokosc { get; set; } = null;
        public decimal? Waga { get; set; } = null;

        public string PoleWlasne { get; set; } = null;


        public List<string> SymboleSkladnikow { get; set; } = new List<string>();
        public List<decimal> IloscSkladnikow { get; set; } = new List<decimal>();
        public List<byte[]> Zdjecia { get; set; } = new List<byte[]>();
        public byte[] ZdjecieDomyslne { get; set; } = null;

        public string PoleIdentyfikacyjne { get; set; }


        public PreTowar()
        {

        }

        public PreTowar(ERodzajTowaru rodzaj)
        {
            this.Rodzaj = rodzaj;
        }

        public PreTowar(string symbol, string nazwa, string vat = "23", string JM = "szt.", decimal cenaKartotekowaNetto = 0, string kodKreskowy = "", string symbolDostawcy = "")
        {
            this.Symbol = symbol;
            this.Nazwa = nazwa;
            this.Vat = vat;
            this.JM = JM;
            this.CenaKartotekowaNetto = cenaKartotekowaNetto;
            this.KodKreskowy = kodKreskowy;
            this.SymbolDostawcy = symbolDostawcy;
        }

    }
}
