using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disconnectedModeTPpartie1
{
    class GestionDataSet
    {
        //La connexion
        static SqlConnection con = new SqlConnection();
        //la commande select
        static SqlCommand CmdSelect = new SqlCommand();
        //la base locale
        private static DataSet ds;
        //le pont : l'adapter
        static  SqlDataAdapter da = new SqlDataAdapter();
        public static DataSet getDataSet() 
        {
            if (ds == null)
            {
                ds = new DataSet();
                con.ConnectionString =
                  @"Data Source=.\SQLEXPRESS;Initial Catalog=Biblio;Integrated Security=true";

                CmdSelect.CommandText = "Select * From Livre";
                CmdSelect.Connection = con;
                da.SelectCommand = CmdSelect;
                //Ramener les données à partir de la base d'origine
                da.Fill(ds, "Livre");
            }
           return ds;
        }
    }
}
