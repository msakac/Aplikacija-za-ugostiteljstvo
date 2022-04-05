# Aplikacija za ugostiteljstvo


## Projektni tim

Ime i prezime   | E-mail adresa (FOI) | JMBAG      | Github korisničko ime
--------------  | ------------------- | ---------- | ---------------------
Martin Sakač    | msakac@foi.hr       | 0016132076 | msakac
Borna Rosandić  | brosandic@foi.hr    | 0016129789 | Borna1324

## Opis domene
Domena ove aplikacije bila bi ugostiteljske djelatnosti, točnije kafići. U današnjici svi kafići moraju raditi račune, pohranjivati ih i mapraviti izvještaja. Ova aplikacija obuhvatila bi sveukupno poslovanje nekog ugostiteljskog objekta. Aplikacija će imati sučelje za prijavu. U aplikaciju će se moći prijaviti kao korisnik ili kao administrator. Administrator će imati privilegije da kreira i briše korisnike, kreira, briše i uređuje artikle iz baze podataka. Običan korisnik će odabirom ponuđenih artikala izrađivati račune za svaki stol te će se podaci spremati u bazu podataka, imat će uvid u stanje skladišta i blagajne te izradu izvješća o prodaji. Za svaku formu bit će izrađena interaktivna pomoć za korisnike. 

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Za pristup radnom sučelju potrebna je autentifikacija odnosno prijava kao administrator ili korisnik | Martin Sakač
F02 | Administrator - Upravljanje korisnicima | dodavanje, ažuriranje i brisanje korisnika u bazu podataka koji mogu pristupiti aplikaciji | Martin Sakač
F03 | Administrator - Upravljanje artiklima | dodavanje, ažuriranje i brisanje artikala u bazu podataka i sustav | Borna Rosandić
F04 | Izrada računa | Kreiranje računa odabirom artikala i spremanje računa u bazu podataka | Borna Rosandić
F05 | Stanja skladišta | Prikaz količine artikala na skladištu | Borna Rosandić
F06 | Stanje blagajne | Prikaz stanja blagajne tj. količina prometa i broj prodanih artikala u toku dana | Borna Rosandić
F07 | Izvješća prodaje | Prikaz podataka o prodaji u izabranom vremenskom roku ili artiklu | Martin Sakač
F08 | Interaktivna pomoć | Prikaz i pojašnjenje načina rada aplikacije u svakoj formi | Martin Sakač, Borna Rosandić
F09 | Izrada baze podataka | Izrada baze podataka koja će komunicirati sa aplikacijom | Martin Sakač
## Tehnologije i oprema  
Za izradu baze podataka i ERA dijagrama koristit će se MySql Workbench 9.0. 
Za izradu sučelja i programiranje same aplikacije koristit će se C# u Visual Studio 2019 .
Osim navedenih još će se koristiti GitHub kao repozitorij za aplikaciju.
