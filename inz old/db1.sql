CREATE TABLE Dostawcy (
  Numer zamowienia INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Sklep_Produkty VARCHAR BINARY NOT NULL,
  Pracownik zamawiajacy VARCHAR BINARY NULL,
  Data_2 DATE NULL,
  Adres firmy VARCHAR BINARY NULL,
  Lista zamowienia VARCHAR BINARY NULL,
  PRIMARY KEY(Numer zamowienia),
  INDEX Dostawcy_FKIndex1(Sklep_Produkty),
  INDEX Dostawcy_FKIndex2(Sklep_Produkty)
);

CREATE TABLE Dostawcy_has_Zamowienia (
  Dostawcy_Numer zamowienia INTEGER UNSIGNED NOT NULL,
  Zamowienia_Numer zamowiena INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(Dostawcy_Numer zamowienia, Zamowienia_Numer zamowiena),
  INDEX Dostawcy_has_Zamowienia_FKIndex1(Dostawcy_Numer zamowienia),
  INDEX Dostawcy_has_Zamowienia_FKIndex2(Zamowienia_Numer zamowiena)
);

CREATE TABLE Klienci (
  Imie VARCHAR BINARY NOT NULL AUTO_INCREMENT,
  Pracownicy_Imie VARCHAR BINARY NOT NULL,
  Sklep_Produkty VARCHAR BINARY NOT NULL,
  Nazwisko VARCHAR BINARY NULL,
  Adres VARCHAR BINARY NULL,
  Telefon VARCHAR BINARY NULL,
  E-mail VARCHAR BINARY NULL,
  Zamowienie VARCHAR BINARY NULL,
  PRIMARY KEY(Imie),
  INDEX Klienci_FKIndex1(Sklep_Produkty),
  INDEX Klienci_FKIndex2(Pracownicy_Imie)
);

CREATE TABLE Klienci_has_Produkty (
  Klienci_Imie VARCHAR BINARY NOT NULL,
  Produkty_Nr produktu INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(Klienci_Imie, Produkty_Nr produktu),
  INDEX Klienci_has_Produkty_FKIndex1(Klienci_Imie),
  INDEX Klienci_has_Produkty_FKIndex2(Produkty_Nr produktu)
);

CREATE TABLE Pracownicy (
  Imie VARCHAR BINARY NOT NULL AUTO_INCREMENT,
  Sklep_Produkty VARCHAR BINARY NOT NULL,
  Nazwisko VARCHAR BINARY NULL,
  Adres VARCHAR BINARY NULL,
  Dane VARCHAR BINARY NULL,
  Zarobki VARCHAR BINARY NULL,
  Przyjete zamowienia VARCHAR BINARY NULL,
  PRIMARY KEY(Imie),
  INDEX Pracownicy_FKIndex1(Sklep_Produkty)
);

CREATE TABLE Produkty (
  Nr produktu INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Sklep_Produkty VARCHAR BINARY NOT NULL,
  Nazwa VARCHAR BINARY NULL,
  Kategoria VARCHAR BINARY NULL,
  Cena INTEGER UNSIGNED NULL,
  PRIMARY KEY(Nr produktu),
  INDEX Produkty_FKIndex1(Sklep_Produkty)
);

CREATE TABLE Sklep (
  Produkty VARCHAR BINARY NOT NULL AUTO_INCREMENT,
  Klienci VARCHAR BINARY NULL,
  Zamowienia VARCHAR BINARY NULL,
  Pracownicy VARCHAR BINARY NULL,
  Dostawcy VARCHAR BINARY NULL,
  PRIMARY KEY(Produkty)
);

CREATE TABLE Zamowienia (
  Numer zamowiena INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Pracownicy_Imie VARCHAR BINARY NOT NULL,
  Sklep_Produkty VARCHAR BINARY NOT NULL,
  Pracownicy przyjmujacy zamowienie VARCHAR BINARY NULL,
  Klienci zamawiajacy VARCHAR BINARY NULL,
  Adres klienta VARCHAR BINARY NULL,
  Dane Klienta VARCHAR BINARY NULL,
  data przyjecia DATE NULL,
  data wyslania DATE NULL,
  stan zamowienia VARCHAR BINARY NULL,
  PRIMARY KEY(Numer zamowiena),
  INDEX Zamowienia_FKIndex1(Sklep_Produkty),
  INDEX Zamowienia_FKIndex2(Pracownicy_Imie)
);


