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
    public partial class Form1 : Form
    {
        DataSet ds= GestionDataSet.getDataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Lier la liste à la table livre
            listBoxLivres.DataSource = ds.Tables["Livre"];
            listBoxLivres.DisplayMember = "Titre";
        }
    }
}
