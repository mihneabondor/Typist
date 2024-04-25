using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Typist.DatabaseDataSetTableAdapters;

namespace Typist
{
    public static class Database
    {
        public static DataSet ds;

        public static DataSetTableAdapters.JucatoriTableAdapter Jucatori = new DataSetTableAdapters.JucatoriTableAdapter();
        public static DataSetTableAdapters.EvidentaTableAdapter Evidenta;
        public static DataSetTableAdapters.JocuriTableAdapter Jocuri;
        public static DataSetTableAdapters.DetaliiTableAdapter Detalii;
        public static DataSetTableAdapters.IntersectieTableAdapter Intersectie;
        public static DataSetTableAdapters.CuvinteTableAdapter Cuvinte;

        static Database()
        {
            ds = new DataSet();
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
    }
}
