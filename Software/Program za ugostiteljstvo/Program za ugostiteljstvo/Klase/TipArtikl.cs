using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kreirao: Borna Rosandić

namespace Program_za_ugostiteljstvo.Klase
{
    public class TipArtikl
    {
        public Int64 Id { get; set; }
        public string Naziv { get; set; }
        public TipArtikl()
        {

        }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
