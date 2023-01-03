using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disconnectedModeTPpartie1
{
    public partial class Form2 : Form
    {
        DataSet ds = GestionDataSet.getDataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            //Lier le comboBox à la table Auteur
       DataTable dt= 
       ds.Tables["Livre"].DefaultView.ToTable(true, "Auteur");
       comboBoxAuteurs.DataSource = dt;
       comboBoxAuteurs.DisplayMember = "Auteur";

          //Lier Datagrid à la table livre
       GrilleLivres.DataSource = ds.Tables["Livre"];
        }

        private void comboBoxAuteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAuteurs.SelectedIndex != -1)
            {
            ds.Tables["Livre"].DefaultView.RowFilter 
                    = "Auteur ='" + comboBoxAuteurs.Text + "'";
           }
        }
    }
}
