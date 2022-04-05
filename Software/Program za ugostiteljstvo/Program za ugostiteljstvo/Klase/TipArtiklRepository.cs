using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kreirao: Borna Rosandić

namespace Program_za_ugostiteljstvo.Klase
{
    static class TipArtiklRepository
    {
        static List<TipArtikl> listaTipArtikla = null;

        /// <summary>
        /// metoda za dohvaćanje svih tipova artikala
        /// </summary>
        /// <returns></returns>
        public static List<TipArtikl> DohvatiTipoveArtikla()
        {
            string sql = "SELECT * FROM TipArtikl";
            listaTipArtikla = DohvatiTipoveArtiklaDB(sql);
            return listaTipArtikla;
        }

        /// <summary>
        /// metoda za dohvaćanje tipova artikala u listu 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static List<TipArtikl> DohvatiTipoveArtiklaDB(string sql)
        {
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            List<TipArtikl> tipoviArtikla = new List<TipArtikl>();

            while (dataReader.Read())
            {
                Int64 id = (Int64)dataReader["Id"];
                string naziv = dataReader["Naziv"].ToString();
                TipArtikl tipArtikl = new TipArtikl()
                {
                    Id = id,
                    Naziv = naziv,
                };
                tipoviArtikla.Add(tipArtikl);
            }//while
            dataReader.Close();
            Database.Instance.Disconnect();
            return tipoviArtikla;
        }

        /// <summary>
        /// metoda za dohvaćanje tipa artikla prema ID-u
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TipArtikl DohvatiTipArtikla(Int64 id)
        {
            TipArtikl returnMe = null;
            if (listaTipArtikla == null)
            {
                DohvatiTipoveArtikla();
            }
            returnMe = listaTipArtikla.FirstOrDefault(a=> a.Id == id);
            return returnMe;
        }
    }
}
