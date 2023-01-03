using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disconnectedModeTPpartie1
{
    public partial class Form3 : Form
    {
        DataSet ds;
        private bool charger = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Obtenir le DataSet
            ds = GestionDataSet.getDataSet();

            //Les laisons

            comboBoxThemes.DataSource = ds.Tables["Theme"];
            comboBoxThemes.DisplayMember = "IntituleTh";
            comboBoxThemes.ValueMember = "CodeTh";

            comboBoxLivres.DataSource = ds.Tables["Livre"];
            comboBoxLivres.DisplayMember = "Titre";
            comboBoxLivres.ValueMember = "CodeTh";

           GrilleLivres.DataSource = ds.Tables["Livre"];

            charger = true;
           
        }

        private void comboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////
            if (charger)
            {
                /*  GrilleLivres.Rows.Clear();
                  int selectedcodeth = Convert.ToInt32(comboBoxThemes.SelectedValue);
                  foreach(DataRow row in ds.Tables["Livre"].Rows)
                  {
                      if((int)row["CodeTh"]==selectedcodeth)
                      {
                          GrilleLivres.Rows.Add(row["CodeL"], row["Titre"], row["Auteur"]);
                      }
                  }*/

                /*ds.Tables["Livre"].DefaultView.RowFilter = 
                    "CodeTh=" + Convert.ToInt32(comboBoxThemes.SelectedValue);
                */

                DataView view = new DataView(ds.Tables["Livre"],
                    "CodeTh=" + Convert.ToInt32(comboBoxThemes.SelectedValue),
                    "", DataViewRowState.CurrentRows);

                GrilleLivres.DataSource = view;
            }
        }

        private void comboBoxLivres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charger)
            {
                int selectedcodeth =
                Convert.ToInt32(comboBoxLivres.SelectedValue);

                DataRow[] rows = ds.Tables["Theme"].Select("CodeTh=" + selectedcodeth);
                labelTheme.Text = "Theme : " + rows[0]["IntituleTh"];
            }
        }
    }
}
