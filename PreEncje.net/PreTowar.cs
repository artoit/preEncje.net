using System.Collections.Generic;

namespace artoit.PreEncjeERP
{
    public enum ERodzajCenyTowaru { Kartotekowa, SprzedazyNetto, SprzedazyBrutto };

    public class PreTowar
    {
        public enum ERodzajTowaru { Towar, Usluga, Komplet, Opakowanie };

        public ERodzajTowaru Rodzaj { get; set; }

        public string Symbol { get; set; }

        public string SymbolDostawcy { get; set; }
        public string NazwaDostawcy { get; set; }
        public string SymbolProducenta { get; set; }
        public string NazwaProducenta { get; set; }
        public string Nazwa { get; set; }
        public decimal CenaKartotekowaNetto { get; set; }
        public decimal CenaNetto { get; set; }
        public decimal CenaBrutto { get; set; }
        public string JM { get; set; }
        public string KodKreskowy { get; set; }
        public string Vat { get; set; }
        public string PKWiU { get; set; }
        public string Opis { get; set; }
        public string OpisPelny { get; set; }
        public string Uwagi { get; set; }
        public string AdresWWW { get; set; }

        public decimal Wysokosc { get; set; }
        public decimal Dlugosc { get; set; }
        public decimal Szerokosc { get; set; }
        public decimal Waga { get; set; }

        public string PoleWlasne { get; set; }


        public PreTowar()
        {
            this.Rodzaj = ERodzajTowaru.Towar;
            BudujObiekt();
        }

        public PreTowar(ERodzajTowaru rodzaj)
        {
            this.Rodzaj = rodzaj;
            BudujObiekt();
        }

        public PreTowar(string symbol, string nazwa, string vat = "23", string JM = "szt.", decimal cenaKartotekowaNetto = 0, string kodKreskowy = "", string symbolDostawcy = "")
        {
            BudujObiekt();
            this.Symbol = symbol;
            this.Nazwa = nazwa;
            this.Vat = vat;
            this.JM = JM;
            this.CenaKartotekowaNetto = cenaKartotekowaNetto;
            this.KodKreskowy = kodKreskowy;
            this.SymbolDostawcy = symbolDostawcy;
        }

        void BudujObiekt()
        {
            Symbol = "";
            SymbolDostawcy = "";
            NazwaDostawcy = "";
            SymbolProducenta = "";
            NazwaProducenta = "";
            Nazwa = "";
            CenaKartotekowaNetto = 0;
            JM = "szt.";
            KodKreskowy = "";
            Vat = "23";
            PKWiU = "";
            Opis = "";
            OpisPelny = "";
            Uwagi = "";
            AdresWWW = "";
            PoleWlasne = "";
        }

        public bool DodajCeneTowaru(string cenaS, ERodzajCenyTowaru rodzajCeny = ERodzajCenyTowaru.Kartotekowa)
        {
            cenaS = cenaS.Replace(" ","");
            cenaS = cenaS.Replace("PLN", "");
            cenaS = cenaS.Replace("zł", "");
            cenaS = cenaS.Replace("zl", "");
            cenaS = cenaS.Replace(".", ",");

            if (decimal.TryParse(cenaS, out decimal CenaDecimal))
            {
                switch(rodzajCeny)
                {
                    case ERodzajCenyTowaru.Kartotekowa:
                        CenaKartotekowaNetto = CenaDecimal;
                        break;
                    case ERodzajCenyTowaru.SprzedazyNetto:
                        CenaNetto = CenaDecimal;
                        break;
                    case ERodzajCenyTowaru.SprzedazyBrutto:
                        CenaBrutto = CenaDecimal;
                        break;
                    default:
                        CenaKartotekowaNetto = CenaDecimal;
                        break;
                }
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal PobierzWartoscVAT()
        {
            if (Vat != null && Vat != "" && Vat != "23")
            {
                Vat = Vat.Replace(".", ",").Trim();

                if (decimal.TryParse(Vat, out decimal vat))
                {
                    return vat;
                }
                else
                {
                    return 23;
                }
            }
            else
            {
                return 23;
            }
        }

    }
}
