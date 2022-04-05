using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

//Kreirao: Martin Sakač

namespace Program_za_ugostiteljstvo.Klase
{
    public class Korisnik
    {
        public Int64 Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string LozinkaSHA1 { get; set; }
        public Int64 IdUloga { get; set; }
        public int Obrisan { get; set; }

        public Korisnik()
        {

        }
        public Korisnik(Int64 id, string ime, string prezime, string korisnickoIme, string lozinka, Int64 uloga, int obrisan)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            IdUloga = uloga;
            Obrisan = obrisan;
            LozinkaSHA1 = dohvatiSHA1(lozinka);
        }

        /// <summary>
        /// Operacija kriptira danu lozinku
        /// </summary>
        /// <param name="lozinka"></param>
        /// <returns></returns>
        public string dohvatiSHA1(string lozinka) 
        {
            string lozinkaSHA = "";

            var data = Encoding.ASCII.GetBytes(lozinka);
            var hashData = new SHA1Managed().ComputeHash(data);

            foreach (var item in hashData)
            {
                lozinkaSHA += item.ToString("X2");
            }
            return lozinkaSHA;
        }
        public override string ToString()
        {
            return this.KorisnickoIme;
        }
    }
}
