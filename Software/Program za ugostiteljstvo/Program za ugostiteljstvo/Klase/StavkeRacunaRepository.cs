using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kreirao: Martin Sakač

namespace Program_za_ugostiteljstvo.Klase
{
    static class StavkeRacunaRepository
    {
        static List<StavkaRacuna> stavkeRacuna = null;
        public static List<StavkaRacuna> DohvatiStavkeRacuna()
        {
            string sql = "";
            sql = $"SELECT * FROM StavkaRacuna";
            stavkeRacuna = DohvatiStavkeRacunaDB(sql);
            return stavkeRacuna;
        }
        /// <summary>
        /// Dohvaca stavke koje se nalaze na odredenom racunu 
        /// </summary>
        /// <param name="racun">Objekt klase Racun</param>
        /// <returns></returns>
        public static List<StavkaRacuna> DohvatiStavkePoRacunu(Racun racun)
        {
            string sql = "";
            sql = $"SELECT * FROM StavkaRacuna WHERE IdRacun = {racun.Id}";
            stavkeRacuna = DohvatiStavkeRacunaDB(sql);
            return stavkeRacuna;
        }
        /// <summary>
        /// Dohvaca sve stavke racuna
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static List<StavkaRacuna> DohvatiStavkeRacunaDB(string sql)
        {
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            List<StavkaRacuna> stavkeRacuna = new List<StavkaRacuna>();

            while (dataReader.Read())
            {
                Racun racun = RacunRepository.DohvatiRacun((Int64)dataReader["IdRacun"]);
                Artikl artikl = ArtiklRepository.DohvatiArtikl((Int64)dataReader["IdArtikl"]);
                string naziv = dataReader["Naziv"].ToString();
                double cijena = (double)dataReader["Cijena"];
                int kolicina = (int)dataReader["Kolicina"];
                StavkaRacuna stavkaRacuna = new StavkaRacuna()
                {
                    IdRacun = racun,
                    IdArtikl = artikl,
                    Naziv = naziv,
                    Cijena = cijena,
                    Kolicina = kolicina
                };
                stavkeRacuna.Add(stavkaRacuna);
            }//while
            dataReader.Close();
            Database.Instance.Disconnect();
            return stavkeRacuna;
        }
        /// <summary>
        /// Dodaje stavku racuna u bazu podataka
        /// </summary>
        /// <param name="stavkaRacuna">Objekt klase StavkaRacuna</param>
        /// <param name="IdRacun">IId racuna na kojem se nalazi stavka</param>
        /// <returns></returns>
        public static int DodajStavkuRacuna(StavkaRacuna stavkaRacuna, int IdRacun)
        {
            //IdRacun, IdArtikl, Naziv, Cijena, Kolicina
            Database.Instance.Connect();
            string sql = $"INSERT INTO StavkaRacuna (IdRacun, IdArtikl, Naziv, Cijena, Kolicina) " +
                $"VALUES ({IdRacun}, {stavkaRacuna.IdArtikl.Id}, '{stavkaRacuna.Naziv}', {stavkaRacuna.Cijena}, {stavkaRacuna.Kolicina})";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
        /// <summary>
        /// Brise stavke racuna prema id-u racuna
        /// </summary>
        /// <param name="racun"></param>
        /// <returns></returns>
        public static int ObrisiStavkeRacuna(Racun racun)
        {
            Database.Instance.Connect();
            string sql = $"DELETE FROM StavkaRacuna WHERE IdRacun={racun.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

    }
}
