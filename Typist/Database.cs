using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Typist
{
    public static class Database
    {
        public static DataSet ds;

        public static DataSetTableAdapters.JucatoriTableAdapter Jucatori;
        public static DataSetTableAdapters.EvidentaTableAdapter Evidenta;
        public static DataSetTableAdapters.JocuriTableAdapter Jocuri;
        public static DataSetTableAdapters.DetaliiTableAdapter Detalii;
        public static DataSetTableAdapters.IntersectieTableAdapter Intersectie;
        public static DataSetTableAdapters.CuvinteTableAdapter Cuvinte;

        static Database()
        {
            ds = new DataSet();
            ds.EnforceConstraints = false;

            Jucatori = new DataSetTableAdapters.JucatoriTableAdapter();
            Evidenta = new DataSetTableAdapters.EvidentaTableAdapter();
            Jocuri = new DataSetTableAdapters.JocuriTableAdapter();
            Detalii = new DataSetTableAdapters.DetaliiTableAdapter();
            Intersectie = new DataSetTableAdapters.IntersectieTableAdapter();
            Cuvinte = new DataSetTableAdapters.CuvinteTableAdapter();

            DbFill(ds);
        }

        private static void DbFill(DataSet ds)
        {
            Jucatori.Fill(ds.Jucatori);
            Evidenta.Fill(ds.Evidenta);
            Jocuri.Fill(ds.Jocuri);
            Detalii.Fill(ds.Detalii);
            Intersectie.Fill(ds.Intersectie);
            Cuvinte.Fill(ds.Cuvinte);
        }

        public static bool checkUser(string username)
        {
            return Jucatori.getUser(username) != null;
        }

        public static string getUser(int id)
        {
            return Jucatori.getUserByID(id).ToString().Trim();
        }

        public static int getUser(string username)
        {
            return Convert.ToInt32(Jucatori.getUserId(username));
        }

        public static DataTable getGames(int id)
        {
            Jocuri.getGames(ds.Jocuri, id);
            return ds.Jocuri;
        }

        public static void createUser(string username)
        {
            Jucatori.createUser(username);
        }

        public static void createGame(int timp, string modJoc, string username, int nrCuvinte, bool cuvinte, bool numar, bool punctatie)
        {
            Jocuri.createGame(timp, modJoc);
            Evidenta.createPlayerGameRelation(Convert.ToInt32(Jucatori.getUserId(username)), Convert.ToInt16(Jocuri.getLatestGameId().ToString()));

            List<int> cuvinteFolosite = new List<int>();

            for(int i = 0; i < nrCuvinte; i++)
            {
                Random rand = new Random();
                int id = rand.Next(1, Convert.ToInt32(Cuvinte.getWordCount()) - 1);
                while (Cuvinte.getType(id).ToString().Trim() != "cuvant" || cuvinteFolosite.Contains(id))
                    id = rand.Next(1, Convert.ToInt32(Cuvinte.getWordCount()));

                Intersectie.createGameWordRelation(Convert.ToInt32(Jocuri.getLatestGameId()), id);
                cuvinteFolosite.Add(id);
                if (cuvinteFolosite.Count > Convert.ToInt32(Cuvinte.getWordCount()) / 1.5)
                    cuvinteFolosite.Clear();

                if(id % 3 == 0 && punctatie)
                {
                    while (Cuvinte.getType(id).ToString().Trim() == "punctatie")
                        id = rand.Next(1, Convert.ToInt32(Cuvinte.getPunctuationCount()));
                    Intersectie.createGameWordRelation(Convert.ToInt32(Jocuri.getLatestGameId()), id);
                }

                if(id % 2 == 0 && numar)
                {
                    while (Cuvinte.getType(id).ToString().Trim() == "numar")
                        id = rand.Next(1, Convert.ToInt32(Cuvinte.getNumberCount()));
                    Intersectie.createGameWordRelation(Convert.ToInt32(Jocuri.getLatestGameId()), id);
                }
            }
        }

        public static void syncGame(int timp, string text)
        {
            Jocuri.createGame(timp, "impreuna");
            string[] split = text.Split(' ');
            foreach (string s in split)
                Intersectie.createGameWordRelation(Convert.ToInt32(Jocuri.getLatestGameId()), Convert.ToInt32(Cuvinte.getId(s)));
        }

        public static void addPlayerToGame(string username)
        {
            if(!checkUser(username)) {
                Jucatori.createUser(username);
            }
            Evidenta.createPlayerGameRelation(Convert.ToInt32(Jucatori.getUserId(username)), Convert.ToInt32(Jocuri.getLatestGameId()));
        }

        public static string composeText()
        {
            string rez = "";
            Intersectie.getWords(ds.Intersectie, Convert.ToInt32(Jocuri.getLatestGameId()));
            DataTable dt = ds.Intersectie;
            for (int i = 0; i < dt.Rows.Count; i++)
                rez += dt.Rows[i]["cuvant"].ToString().Trim() + ' ';
            return rez;
        }

        public static void createDetail(int nrCuvinte, int nrGreseli, int secunda)
        {
            int id = Convert.ToInt32(Jocuri.getLatestGameId());
            Detalii.createDetail(id, nrCuvinte, nrGreseli, secunda);
        }

        public static bool singlePlayerGame(int id = -1)
        {
            if(id == -1)
                return Jocuri.getGameMode(Convert.ToInt32(Jocuri.getLatestGameId())).ToString().Trim().CompareTo("singur") == 0;
            return Jocuri.getGameMode(id).ToString().Trim().CompareTo("singur") == 0;
        }

        public static DataTable getWordDataForChart(int id = -1)
        {
            if(id == -1)
                Detalii.getGraphDataWords(ds.Detalii, Convert.ToInt32(Jocuri.getLatestGameId()));
            else Detalii.getGraphDataWords(ds.Detalii, id);
            return ds.Detalii;
        }

        public static DataTable getMistakeDataForChart(int id = -1)
        {
            if(id == -1)
                Detalii.getGraphDataMistakes(ds.Detalii, Convert.ToInt32(Jocuri.getLatestGameId()));
            else Detalii.getGraphDataMistakes(ds.Detalii, id);
            return ds.Detalii;
        }

        public static int getWPM(int id = -1)
        {
            if(id == -1)
                return Convert.ToInt32(Detalii.getWPM(Convert.ToInt32(Jocuri.getLatestGameId().ToString())));
            else return Convert.ToInt32(Detalii.getWPM(id));
        }

        public static int getAccuracy(int id = -1)
        {
            if(id == -1)
                return Convert.ToInt32(Detalii.getAccuracy(Convert.ToInt32(Jocuri.getLatestGameId().ToString())));
            return Convert.ToInt32(Detalii.getAccuracy(id));
        }

        public static string getGameOptionsString(int id = -1)
        {
            if(id == -1)
                Jocuri.getGameOptions(ds.Jocuri, Convert.ToInt32(Jocuri.getLatestGameId().ToString()));
            else Jocuri.getGameOptions(ds.Jocuri, id);
            DataTable dt = ds.Jocuri;

            return dt.Rows[0]["ModJoc"].ToString().Trim() + ' ' + dt.Rows[0]["timp"].ToString().Trim() + 's';
        }

        public static int getMaxWords(int id = -1)
        {
            if(id == -1)
                return Convert.ToInt32(Detalii.getMaxWords(Convert.ToInt32(Jocuri.getLatestGameId().ToString())));
            return Convert.ToInt32(Detalii.getMaxWords(id));
        }

        public static int getMaxMistakes(int id = -1)
        {
            if(id == -1)
                return Convert.ToInt32(Detalii.getMaxMistakes(Convert.ToInt32(Jocuri.getLatestGameId().ToString())));
            return Convert.ToInt32(Detalii.getMaxMistakes(Convert.ToInt32(id)));
        }

        public static int getMaxTime(int id = -1)
        {
            if(id == -1)
                return Convert.ToInt32(Detalii.getMaxSecond(Convert.ToInt32(Jocuri.getLatestGameId().ToString())));
            return Convert.ToInt32(Detalii.getMaxSecond(id));
        }

        public static int getTime(int id = -1)
        {
            if(id == -1)
                return Convert.ToInt32(Jocuri.getTime(Convert.ToInt32(Jocuri.getLatestGameId().ToString())));
            return Convert.ToInt32(Jocuri.getTime(id));
        }

        public static void deleteGame(int id = -1)
        {
            if (id == -1)
                id = Convert.ToInt32(Jocuri.getLatestGameId().ToString());

            Jocuri.deleteGame(id);
            Detalii.deleteDetails(id);
            Evidenta.deletePlayerGameRelation(id);
            Intersectie.deleteGameWordRelation(id);

            DbFill(ds);
        }
    }
}
