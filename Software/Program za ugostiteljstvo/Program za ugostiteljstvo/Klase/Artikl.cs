using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kreirao: Borna Rosandić

namespace Program_za_ugostiteljstvo.Klase
{
    class Artikl
    {
        public Int64 Id { get; set; }
        public string Naziv { get; set; }
        public TipArtikl IdTipArtikl { get; set; }
        public double Doza { get; set; }
        public double Cijena { get; set; }
        public int DostupnaKolicina { get; set; }
        public int KriticnaKolicina { get; set; }
        public int Obrisan { get; set; }

        public Artikl()
        {

        }
        public Artikl(Int64 id, string naziv, TipArtikl idTipArtikl, double doza, double cijena, int dostupnaKolicina, int kriticnaKolicina, int obrisan)
         {
            Id = id;
            Naziv = naziv;
            IdTipArtikl = idTipArtikl;
            Doza = doza;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
            KriticnaKolicina = kriticnaKolicina;
            Obrisan = obrisan;
         }
    }
}
