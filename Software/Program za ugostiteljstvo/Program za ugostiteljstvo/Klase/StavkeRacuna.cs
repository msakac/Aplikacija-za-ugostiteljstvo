using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kreirao: Martin Sakač

namespace Program_za_ugostiteljstvo.Klase
{
    class StavkaRacuna
    {
        public Racun IdRacun { get; set; }
        public Artikl IdArtikl { get; set; }
        public string Naziv{ get; set; }
        public double Cijena { get; set; }
        public int Kolicina { get; set; }
        public StavkaRacuna(Artikl idArtikl,string nazivArtikla, double cijena, int kolicina)
        {
            IdArtikl = idArtikl;
            Naziv = nazivArtikla;
            Cijena = cijena;
            Kolicina = kolicina;
        }
        public StavkaRacuna()
        {

        }
        public override string ToString()
        {
            return IdArtikl.Naziv;
        }
    }
}
