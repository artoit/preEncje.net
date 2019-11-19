using System;
using System.Collections.Generic;

namespace artoit.PreEncjeERP
{
    public class PreDokument
    {
        public PreAdres AdresDostawy { get; set; } = null;

        /// <summary>
        /// Startowo null
        /// </summary>
        public PreKlient Klient { get; set; } = null;

        public string UslugaTransportu { get; set; } = "";
        public decimal UslugaTransportuCenaNetto { get; set; }
        public decimal UslugaTransportuCenaBrutto { get; set; }
        public string UslugaTransportuUwagi { get; set; }

        public int Numer { get; set; } = -1;
        public string NumerPelny { get; set; } = "";
        public string NumerZewnetrzny { get; set; } = "";
        public string NumerZewnetrzny2 { get; set; } = "";
        public string Podtytul { get; set; } = "";

        public DateTime DataUtworzenia { get; set; } = DateTime.Now;
        public DateTime? DataDostawy { get; set; } = null;
        public DateTime? DataOtrzymania { get; set; } = null;

        /// <summary>
        /// Data platnosci dokumentu
        /// </summary>
        public DateTime? TerminPlatnosci { get; set; } = null;

        public List<PrePozycja> Produkty { get; set; } = new List<PrePozycja>();

        public string Uwagi { get; set; } = "";
        public string RodzajPlatnosci { get; set; } = "";
        public string Waluta { get; set; } = "PLN";
        public decimal? WalutaKurs { get; set; } = null;

        public decimal Rabat { get; set; }

        public decimal WartoscPoRabacieNetto { get; set; }
        public decimal WartoscPoRabacieBrutto { get; set; }
        public decimal WartoscNetto { get; set; }
        public decimal WartoscBrutto { get; set; }

        public decimal WartoscWplacona { get; set; }

        public ETypDokumentu_HandloMag? TypDokumentu { get; set; } = null;

        public ERodzajTransakcjiVAT? RodzajTransakcjiVAT { get; set; } = null;
        public int? KodRodzajuTransakcji { get; set; } = null;

        public string StatusDokumentuWERP { get; set; } = "";
        public string Kategoria { get; set; } = "";

        public string Magazyn { get; set; } = "";

        /// <summary>
        /// Do obsługi MM
        /// </summary>
        public string MagazynDo { get; set; } = "";

        public bool LiczonyOdNetto { get; set; } = true;

        public bool? PodzielonaPlatnosc { get; set; } = null;
        public bool? MetodaKasowa { get; set; } = null;

    }
}
