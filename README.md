# preEncje.net dla Importera Zamówień do Subiekta GT/Subiekta nexo PRO
Biblioteczka obiektów w języku C#, wspomagająca serializację i deserializację plików XML dla [Importera wielu dokumentów do Subiekta GT](https://www.artoit.pl/moduly/gt/import_zamowien.html#nav).

Importer pozwala na masowy import dokumentów handlowo-magazynowych do programu InsERT Subiekt GT + Sfera. 

Biblioteczka została udostępniona, aby ułatwić developerom tworzenie własnych rozwiązań integrujących Subiekta z różnego rodzaju systemami zewnętrzny, przy pomocy naszego importera.

## Technologia
* .NET Standard 2.0 - umożliwia współpracę z projektami w .NET Framework i .NET Core

## Przykład wykorzystania
```C#
XmlSerializer serializer = new XmlSerializer(typeof(PreDokument));
var preDokument = new PreDokument();
preDokument.TypDokumentu = ETypDokumentu_HandloMag.ZK;
preDokument.DataUtworzenia = DateTime.Now;
preDokument.Kategoria = "Zamówienia B2B";
preDokument.Magazyn = "MAG";
preDokument.Numer = 312;
preDokument.NumerZewnetrzny = "312/Z/B2B/2019";
preDokument.RodzajPlatnosci = "Kredyt kupiecki";
preDokument.TerminPlatnosci = preDokument.DataUtworzenia.AddDays(14);
preDokument.Uwagi = "Pakowane razem";

// kontrahent
preDokument.Klient = new PreKlient()
{
  Typ = EPreKlientTyp.Firma,
  Nazwa = "Fajna Firma sp. z o.o.",
  NIP = "0000000000",
  Email = "kontak@fajnafirma.net",
  Symbol = "fajnafirma",
  AdresGlowny = new PreAdres()
    {
      Nazwa = "Fajna Firma sp. z o.o.",
      Kod = "12-777",
      Miasto = "Warszawa",
      Ulica = "Rynek 3/9a",
      Panstwo = "Polska"
    }
};

// towary
var prePozycjaA = new PrePozycja();
prePozycjaA.Towar = new PreTowar()
{
  Symbol = "aaa",
  Nazwa = "Towar aaa",
  JM = "szt.",
  KodKreskowy = "11111"
};
prePozycjaA.Ilosc = 5;
prePozycjaA.Vat = 23;
prePozycjaA.CenaNettoPoRabacie = 50.49m;

preDokument.Produkty.Add(prePozycjaA);

var prePozycjaB = new PrePozycja();
prePozycjaB.Towar = new PreTowar()
{
  Symbol = "bbb",
  Nazwa = "Towar bbb",
  JM = "szt.",
  KodKreskowy = "2222"
};
prePozycjaB.Ilosc = 3;
prePozycjaB.Vat = 5;
prePozycjaB.CenaNettoPoRabacie = 10.75m;

preDokument.Produkty.Add(prePozycjaB);

using (FileStream xml = new FileStream(path + ".xml", FileMode.Create))
{
  serializer.Serialize(xml, preDokument);
}
```

## Kontakt
__ARTOIT__

https://www.artoit.pl

email: dev@artoit.pl
