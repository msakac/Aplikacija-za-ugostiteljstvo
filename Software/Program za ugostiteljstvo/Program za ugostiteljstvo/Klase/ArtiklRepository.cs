using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program_za_ugostiteljstvo.Forme;

//Kreirao: Borna Rosandić

namespace Program_za_ugostiteljstvo.Klase
{
    static class ArtiklRepository
    {
        static List<Artikl> listaArtikala = null;
        /// <summary>
        /// metoda za dohvaćanje artikla s obzirom na varijablu trazi
        /// </summary>
        /// <param name="atribut"></param>
        /// <param name="trazi"></param>
        /// <returns></returns>

        public static List<Artikl> DohvatiSveArtikle(string atribut, string trazi)
        {
            string sql = "";
            if (atribut == null && trazi == null)
            {
                sql = "SELECT * FROM Artikl";
            }
            else if (trazi == null)
            {
                sql = $"SELECT * FROM Artikl ORDER BY '{atribut}'";
            }
            else
            {
                sql = $"SELECT * FROM Artikl WHERE Naziv LIKE '%{trazi}%'";
            }
            listaArtikala = DohvatiArtikleDB(sql);
            return listaArtikala; 
        }
        public static List<Artikl> DohvatiArtikle()
        {
            string sql = "";
            sql = "SELECT * FROM Artikl WHERE Obrisan != 1";
            listaArtikala = DohvatiArtikleDB(sql);
            return listaArtikala;
        }

        /// <summary>
        /// metoda dohvaća artikle prema njihovom tipu
        /// </summary>
        /// <param name="tipArtikla"></param>
        /// <returns></returns>
        public static List<Artikl> DohvatiArtiklePoTipu(Int64 tipArtikla)
        {
            string sql = "";
            sql = $"SELECT * FROM Artikl WHERE IdTipArtikl = {tipArtikla} AND Obrisan != 1";
            listaArtikala = DohvatiArtikleDB(sql);
            return listaArtikala;
        }

        /// <summary>
        /// metoda dohvaća sve artikle u listu artikala
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static List<Artikl> DohvatiArtikleDB(string sql)
        {
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            List<Artikl> tipoviArtikla = new List<Artikl>();

            while (dataReader.Read())
            {
                Int64 id = (Int64)dataReader["Id"];
                string naziv = dataReader["Naziv"].ToString();
                TipArtikl idTipArtikl = TipArtiklRepository.DohvatiTipArtikla((Int64)dataReader["IdTipArtikl"]);
                double doza = (double)dataReader["Doza"];
                double cijena = (double)dataReader["Cijena"];
                int dostupnaKolicina = (int)dataReader["DostupnaKolicina"];
                int kriticnaKolicina = (int)dataReader["KriticnaKolicina"];
                int obrisan = (int)dataReader["Obrisan"];
                Artikl artikl = new Artikl()
                {
                    Id = id,
                    Naziv = naziv,
                    IdTipArtikl = idTipArtikl,
                    Doza = doza,
                    Cijena = cijena,
                    DostupnaKolicina = dostupnaKolicina,
                    KriticnaKolicina = kriticnaKolicina,
                    Obrisan = obrisan
                };
                tipoviArtikla.Add(artikl);
            }//while
            dataReader.Close();
            Database.Instance.Disconnect();
            return tipoviArtikla;
        }

        /// <summary>
        /// metoda dodaje novi artikl u bazu 
        /// </summary>
        /// <param name="artikl"></param>
        /// <returns></returns>
        public static int DodajArtikl(Artikl artikl)
        {
            //Id, Naziv, IdTipArtikl, Doza, Cijena, DostupnaKolicina, KriticnaKolicina
            Database.Instance.Connect();
            string sql = $"INSERT INTO Artikl (Id, Naziv, IdTipArtikl, Doza, Cijena, DostupnaKolicina, KriticnaKolicina) " +
                $"VALUES ({artikl.Id}, '{artikl.Naziv}', {artikl.IdTipArtikl.Id}, {artikl.Doza}, {artikl.Cijena}, {artikl.DostupnaKolicina}, {artikl.KriticnaKolicina}, 0)";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        /// <summary>
        /// metoda za brisanje artikla iz baze 
        /// </summary>
        /// <param name="artikl"></param>
        /// <returns></returns>
        public static int ObrisiArtikl(Artikl artikl)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Artikl SET Obrisan = 1 WHERE Id = {artikl.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
        
        public static int VratiArtikl(Artikl artikl)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Artikl SET Obrisan = 0 WHERE Id = {artikl.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        /// <summary>
        /// ažuriranje stanja artikla u bazi 
        /// </summary>
        /// <param name="artikl"></param>
        /// <returns></returns>
        public static int AzurirajArtikl(Artikl artikl)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Artikl SET Naziv = '{artikl.Naziv}', IdTipArtikl = {artikl.IdTipArtikl.Id}, Doza = {artikl.Doza}, " +
                $"Cijena = {artikl.Cijena}, DostupnaKolicina = {artikl.DostupnaKolicina}, KriticnaKolicina = {artikl.KriticnaKolicina} WHERE Id = {artikl.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        /// <summary>
        /// dodavanje dostupne količine artikla u bazu
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kolicina"></param>
        /// <returns></returns>
        public static int DodajKolicinu(Int64 id, int kolicina)
        {
            Database.Instance.Connect();
            string sql = $"UPDATE Artikl SET DostupnaKolicina = {kolicina} WHERE Id = {id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        /// <summary>
        /// dohvaćanje artikla prema ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Artikl DohvatiArtikl(Int64 id)
        {
            Artikl returnMe = null;
            if (listaArtikala == null)
            {
                DohvatiSveArtikle(null,null);
            }
            returnMe = listaArtikala.FirstOrDefault(k => k.Id == id);
            return returnMe;
        }

        /// <summary>
        /// metoda za provjeru postojanosti zadanog ID-a
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Artikl ProvjeriID(Int64 id)
        {
            Artikl returnMe = null;
            returnMe = listaArtikala.FirstOrDefault(k => k.Id == id);
            return returnMe;
        }
    }
}
