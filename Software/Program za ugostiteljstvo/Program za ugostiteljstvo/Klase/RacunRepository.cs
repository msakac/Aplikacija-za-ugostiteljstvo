using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kreirao: Borna Rosandić

namespace Program_za_ugostiteljstvo.Klase
{
    static class RacunRepository
    {
        static List<Racun> listaRacuna = null;

        /// <summary>
        /// metoda za dohvaćanje računa iz baze s obzirom na zadani upit 
        /// </summary>
        /// <param name="atribut"></param>
        /// <returns></returns>
        public static List<Racun> DohvatiRacune(string atribut)
        {
            string sql = "";
            if (atribut == null)
            {
                sql = "SELECT * FROM Racun";
            }
            else
            {
                sql = $"SELECT * FROM Racun ORDER BY '{atribut}'";
            }
            listaRacuna = DohvatiRacuneDB(sql);
            return listaRacuna;
        }

        /// <summary>
        /// metoda za dohvaćane svih računa u listu 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static List<Racun> DohvatiRacuneDB(string sql)
        {
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            List<Racun> listaRacuna = new List<Racun>();

            while (dataReader.Read())
            {
                Int64 id = (Int64)dataReader["Id"];
                DateTime? datumVrijeme = (DateTime?)dataReader["DatumVrijeme"];
                double ukupno = (double)dataReader["Ukupno"];
                double osnovica = (double)dataReader["Osnovica"];
                double porez = (double)dataReader["Porez"];
                Korisnik idKorisnik = KorisnikRepository.DohvatiKorisnikaPoID((Int64)dataReader["IdKorisnik"]);
                Racun racun = new Racun()
                {
                    Id = id,
                    DatumVrijeme = datumVrijeme,
                    Ukupno = ukupno,
                    Osnovica = osnovica,
                    Porez = porez,
                    IdKorisnik = idKorisnik,
                };
                listaRacuna.Add(racun);
            }//while
            dataReader.Close();
            Database.Instance.Disconnect();
            return listaRacuna;
        }

        /// <summary>
        /// metoda za dodavanje računa u bazu 
        /// </summary>
        /// <param name="racun"></param>
        /// <returns></returns>
        public static int DodajRacun(Racun racun)
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO Racun (DatumVrijeme, Ukupno, Osnovica, Porez, IdKorisnik) " +
                $"VALUES ('{racun.DatumVrijeme}', {racun.Ukupno}, {racun.Osnovica}, {racun.Porez}, {racun.IdKorisnik.Id})";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        /// <summary>
        /// metoda za dohvaćanje računa prema zadanom ID-u
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Racun DohvatiRacun(Int64 id)
        {
            Racun returnMe = null;
            if (listaRacuna == null)
            {
                DohvatiRacune(null);
            }
            returnMe = listaRacuna.FirstOrDefault(k => k.Id == id);
            return returnMe;
        }

        /// <summary>
        /// brisanje računa iz baze
        /// </summary>
        /// <param name="racun"></param>
        /// <returns></returns>
        public static int ObrisiRacun(Racun racun)
        {
            Database.Instance.Connect();
            string sql = $"DELETE FROM Racun WHERE Id={racun.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        /// <summary>
        /// metoda za dohvaćanje zadnjeg računa u bazu 
        /// </summary>
        /// <returns></returns>
        public static int DohvatiZadnjiRacun()
        {
            Database.Instance.Connect();
            string sql = "SELECT TOP(1) Id FROM Racun ORDER BY Id DESC;";
            var idRaw = Database.Instance.GetValue(sql);
            int id = int.Parse((idRaw.ToString()));
            Database.Instance.Disconnect();
            return id;
        }

        /// <summary>
        /// metoda za dohvaćanje računa prema datumima izdavanja 
        /// </summary>
        /// <returns></returns>
        public static List<Racun> DohvatiRacunePoDatumu()
        {
            string sql = "";
            string datum = DateTime.Now.ToString("MM/dd/yyyy");
            sql = $"SELECT * FROM Racun WHERE DatumVrijeme BETWEEN '{datum}' AND '{datum} 23:59:00'";
            listaRacuna = DohvatiRacuneDB(sql);
            return listaRacuna;
        }
    }
}
