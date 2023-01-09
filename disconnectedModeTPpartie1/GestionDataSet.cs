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
        static  SqlDataAdapter livreAdapter = new SqlDataAdapter();
        static SqlDataAdapter   themeAdapter = new SqlDataAdapter();
        public static SqlDataAdapter adherentAdapter = new SqlDataAdapter();
        public static DataSet getDataSet() 
        {
            if (ds == null)
            {
                ds = new DataSet();
                con.ConnectionString =
                  @"Data Source=.\SQLEXPRESS;Initial Catalog=Biblio;Integrated Security=true";

                /*CmdSelect.CommandText = "Select * From Livre";
                CmdSelect.Connection = con;
                livreAdapter.SelectCommand = CmdSelect;*/
                livreAdapter = new SqlDataAdapter("SELECT * FROM Livre", con);
                themeAdapter = new SqlDataAdapter("SELECT * FROM Theme", con);
                adherentAdapter = new SqlDataAdapter("SELECT * FROM Adherent", con);
                //Ramener les données à partir de la base d'origine
                livreAdapter.Fill(ds, "Livre");
                themeAdapter.Fill(ds, "Theme");
                adherentAdapter.Fill(ds, "Adherent");

                //generer les requetes de MISE A JOUR
                SqlCommandBuilder builder = new SqlCommandBuilder(adherentAdapter);
               
                //On définit les primary key
                DataColumn[] cols_L = { ds.Tables["Livre"].Columns["CodeL"] };
                ds.Tables["Livre"].PrimaryKey = cols_L;
                DataColumn[] cols_Th = { ds.Tables["Theme"].Columns["CodeTh"] };
                ds.Tables["Theme"].PrimaryKey = cols_Th;
                //On definit les cles étrangères
                DataRelation drel = new DataRelation("Theme-Livre",
                ds.Tables["Theme"].Columns["CodeTh"],
                ds.Tables["Livre"].Columns["CodeTh"]);

                ds.Relations.Add(drel);
            }
           return ds;
        }
    }
}
