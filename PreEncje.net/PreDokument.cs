using System;
using System.Collections.Generic;

namespace artoit.PreEncjeERP
{
    public class PreDokument
    {
        public ETypDokumentu_HandloMag? TypDokumentu { get; set; } = null;

        public PreAdres AdresDostawy { get; set; } = null;

        public PreKlient Klient { get; set; } = null;

        public PreKlient Odbiorca { get; set; } = null;

        public string Platnik { get; set; } = null;

        public string UslugaTransportu { get; set; } = null;
        public decimal? UslugaTransportuCenaNetto { get; set; } = null;
        public string UslugaTransportuStawkaVat { get; set; } = null;
        public decimal? UslugaTransportuCenaBrutto { get; set; } = null;
        public string UslugaTransportuUwagi { get; set; } = null;

        public int? Numer { get; set; } = null;
        public string NumerPelny { get; set; } = null;
        public string NumerZewnetrzny { get; set; } = null;
        public string NumerZewnetrzny2 { get; set; } = null;
        public string Podtytul { get; set; } = null;

        public DateTime DataUtworzenia { get; set; } = DateTime.Now;
        public DateTime? DataDostawy { get; set; } = null;
        public DateTime? DataOtrzymania { get; set; } = null;

        /// <summary>
        /// Dla ZK i ZD
        /// </summary>
        public DateTime? TerminRealizacji { get; set; } = null;

        public DateTime? TerminPlatnosci { get; set; } = null;

        public List<PrePozycja> Produkty { get; set; } = new List<PrePozycja>();

        public string Uwagi { get; set; } = null;
        public string RodzajPlatnosci { get; set; } = null;
        public string Waluta { get; set; } = "PLN";
        public decimal? WalutaKurs { get; set; } = null;

        public decimal? Rabat { get; set; } = null;

        public decimal? WartoscPoRabacieNetto { get; set; } = null;
        public decimal? WartoscPoRabacieBrutto { get; set; } = null;
        public decimal? WartoscNetto { get; set; } = null;
        public decimal? WartoscBrutto { get; set; } = null;

        public decimal? WartoscWplacona { get; set; } = null;



        public ERodzajTransakcjiVAT? RodzajTransakcjiVAT { get; set; } = null;
        public int? KodRodzajuTransakcji { get; set; } = null;

        public string StatusDokumentuWERP { get; set; } = null;
        public string Kategoria { get; set; } = null;
        public string Magazyn { get; set; } = null;

        /// <summary>
        /// Do obsługi MM
        /// </summary>
        public string MagazynDo { get; set; } = null;

        public bool? LiczonyOdNetto { get; set; } = null;

        public bool? PodzielonaPlatnosc { get; set; } = null;
        public bool? MetodaKasowa { get; set; } = null;

        public string PanstwoRozpoczeciaWysylki { get; set; } = null;

        public string PanstwoKonsumenta { get; set; } = null;

        public string InformacjeDodatkowe { get; set; } = null;


        public List<PoleWlasne> PolaWlasne { get; set; } = null;

        public string PodajNumer
        {
            get
            {
                if (string.IsNullOrWhiteSpace(NumerPelny) == false)
                    return NumerPelny;
                if (string.IsNullOrWhiteSpace(NumerZewnetrzny) == false)
                    return NumerZewnetrzny;
                if (string.IsNullOrWhiteSpace(NumerZewnetrzny2) == false)
                    return NumerZewnetrzny2;

                return "";
            }
        }
    }
}
