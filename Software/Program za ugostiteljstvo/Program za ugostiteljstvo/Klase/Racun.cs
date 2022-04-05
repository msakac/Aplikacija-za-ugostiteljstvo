using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kreirao: Borna Rosandić

namespace Program_za_ugostiteljstvo.Klase
{
    class Racun
    {
        public Int64 Id { get; set; }
        public DateTime? DatumVrijeme { get; set; }
        public double Ukupno { get; set; }
        public double Osnovica { get; set; }
        public double Porez { get; set; }
        public Korisnik IdKorisnik { get; set; }
        public Racun()
        {

        }
        public Racun(DateTime datumVrijeme, double ukupno, double osnovica, double porez, Korisnik idKorisnik)
        {
            DatumVrijeme = datumVrijeme;
            Ukupno = ukupno;
            Osnovica = osnovica;
            Porez = porez;
            IdKorisnik = idKorisnik;
        }
    }
}
