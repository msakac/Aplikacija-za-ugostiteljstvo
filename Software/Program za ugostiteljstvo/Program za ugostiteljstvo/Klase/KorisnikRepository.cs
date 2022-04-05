using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kreirao: Martin Sakač

namespace Program_za_ugostiteljstvo.Klase
{
    static class KorisnikRepository
    {
        static List<Korisnik> listaKorisnici = null;
        /// <summary>
        /// Dohvaca korisnike iz baze podataka ovisno o danim vrijednostima varijabla atribut i trazi
        /// </summary>
        /// <param name="atribut">Ukoliko kao parametar funkcija dobi varijablu atribut podaci se sortiraju prema tom atributu</param>
        /// <param name="trazi">Ukoliko kao parametar funkcija dobi varijablu trazi u bazi se trazi korisnik koji ima taj dio u svojem korisnickom imenu</param>
        /// <returns></returns>
        public static List<Korisnik> DohvatiKorisnike(string atribut, string trazi)
        {
            string sql = "";
            if (atribut == null && trazi == null)
            {
                sql = "SELECT * FROM Korisnik";
            }
            else if (trazi == null)
            {
                sql = $"SELECT * FROM Korisnik ORDER BY '{atribut}'";
            }
            else
            {
                sql = $"SELECT * FROM Korisnik WHERE KorisnickoIme LIKE '%{trazi}%'";
            }
            listaKorisnici = DohvatiKorisnikeDB(sql);
            return listaKorisnici;
        }
        /// <summary>
        /// Dohvaca sve korisnike iz baze podataka
        /// </summary>
        /// <param name="sql">upit koji se prosljeduje</param>
        /// <returns></returns>
        private static List<Korisnik> DohvatiKorisnikeDB(string sql)
        {
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            List<Korisnik> korisnici = new List<Korisnik>();

            while (dataReader.Read())
            {
                Int64 id = (Int64)dataReader["Id"];
                string ime = dataReader["Ime"].ToString();
                string prezime = dataReader["Prezime"].ToString();
                string korisnickoIme = dataReader["KorisnickoIme"].ToString();
                string lozinka = dataReader["Lozinka"].ToString();
                string lozinkaSHA1 = dataReader["LozinkaSHA1"].ToString();
                Int64 idUloga = (Int64)dataReader["IdUloga"];
                int obrisan = (int)dataReader["Obrisan"];

                Korisnik korisnik = new Korisnik()
                {
                    Id = id,
                    Ime = ime,
                    Prezime = prezime,
                    KorisnickoIme = korisnickoIme,
                    Lozinka = lozinka,
                    LozinkaSHA1 = lozinkaSHA1,
                    IdUloga = idUloga,
                    Obrisan = obrisan
                };
                korisnici.Add(korisnik);
            }//while
            dataReader.Close();
            Database.Instance.Disconnect();
            return korisnici;
        }
        /// <summary>
        /// Dohvaca se korisnik iz baze podataka koji odgovara korisnickom imenu i lozinki
        /// </summary>
        /// <param name="korisnickoIme"></param>
        /// <param name="lozinka"></param>
        /// <returns></returns>
        public static Korisnik DohvatiKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik returnMe = null;
            if (listaKorisnici == null)
            {
                DohvatiKorisnike(null, null);
            }
            returnMe = listaKorisnici.FirstOrDefault(k => k.KorisnickoIme == korisnickoIme && k.LozinkaSHA1.ToUpper() == k.dohvatiSHA1(lozinka) && k.Obrisan != 1);
            return returnMe;
        }
        /// <summary>
        /// Dohvacanje korisnika prema id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Korisnik DohvatiKorisnikaPoID(Int64 id)
        {
            Korisnik returnMe = null;
            if (listaKorisnici == null)
            {
                DohvatiKorisnike(null, null);
            }
            returnMe = listaKorisnici.FirstOrDefault(k => k.Id == id);
            return returnMe;
        }
        /// <summary>
        /// Provjera da li korisnik s ID-om vec postoji u bazi
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Korisnik ProvjeriID(Int64 id)
        {
            Korisnik returnMe = null;
            returnMe = listaKorisnici.FirstOrDefault(k => k.Id == id);
            return returnMe;
        }
        /// <summary>
        /// Provjera da li korisnik s korisnickim imenom vec postoji u  bazi
        /// </summary>
        /// <param name="korime"></param>
        /// <returns></returns>
        public static Korisnik ProvjeriKorisnickoIme(string korime)
        {
            Korisnik returnMe = null;
            returnMe = listaKorisnici.FirstOrDefault(k => k.KorisnickoIme == korime);
            return returnMe;
        }
        /// <summary>
        /// Dodaje novog korisnika u bazu
        /// </summary>
        /// <param name="korisnik">objekt klase Korisnik</param>
        /// <returns></returns>
        public static int DodajKorisnika(Korisnik korisnik)
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO Korisnik (Id, Ime, Prezime, KorisnickoIme, Lozinka, LozinkaSHA1, IdUloga) " +
                $"VALUES ({korisnik.Id}, '{korisnik.Ime}', '{korisnik.Prezime}', '{korisnik.KorisnickoIme}', '{korisnik.Lozinka}', '{korisnik.LozinkaSHA1}', {korisnik.IdUloga}, 0)";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
        /// <summary>
        /// Brisanje korisnika iz baze
        /// </summary>
        /// <param name="korisnik">objekt klase Korisnik</param>
        /// <returns></returns>
        public static int ObrisiKorisnika(Korisnik korisnik)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Korisnik SET Obrisan = 1 WHERE Id={korisnik.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
        public static int VratiKorisnika(Korisnik korisnik)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Korisnik SET Obrisan = 0 WHERE Id={korisnik.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        /// <summary>
        /// Azuriranje korisnika
        /// </summary>
        /// <param name="korisnik">objekt klase Korisnik</param>
        /// <returns></returns>
        public static int AzurirajKorisnika(Korisnik korisnik)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Korisnik SET Ime = '{korisnik.Ime}', Prezime = '{korisnik.Prezime}', KorisnickoIme = '{korisnik.KorisnickoIme}', " +
                $"Lozinka = '{korisnik.Lozinka}', LozinkaSHA1 = '{korisnik.LozinkaSHA1}', idUloga = {korisnik.IdUloga} WHERE Id = {korisnik.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
        /// <summary>
        /// Provjera da li je korisnik admin
        /// </summary>
        /// <param name="korisnik">objekt klase Korisnik</param>
        /// <returns></returns>
        public static bool IsAdmin(Korisnik korisnik)
        {
            bool returnMe = false;
            if (korisnik.IdUloga == 0)
            {
                returnMe = true;
            }

            return returnMe;
        }

    }
}
