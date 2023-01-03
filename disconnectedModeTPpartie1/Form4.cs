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
    public partial class Form4 : Form
    {
        //Le Binding Source = Liaison de données
        private BindingSource binding 
            = new BindingSource();

        //DataSet
        DataSet ds = GestionDataSet.getDataSet();

        const int MODE_LECTURE=1;
        const int MODE_AJOUT = 2;
        const int MODE_MODIFICATIONN = 3;

        private int MODE_FORM = MODE_LECTURE;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Initialisation
            //Preciser le Data
            binding.DataSource = ds.Tables["Adherent"];

            //

            ds.Tables["Adherent"].Columns["DateInscription"].DefaultValue =
                DateTime.Now;

            ds.Tables["Adherent"].Columns["CodeA"].AutoIncrement = true;
          
            //Liser les composants

            textBoxCode.DataBindings.Add("Text", binding, "CodeA");
            textBoxNom.DataBindings.Add("Text", binding, "NomA");
            textBoxAdresse.DataBindings.Add("Text", binding, "Adresse");
            dateTimePickerInscription.DataBindings.Add("Value", binding, "DateInscription");


            modeLecture();
        }

        private void buttonfirst_Click(object sender, EventArgs e)
        {
            binding.MoveFirst();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            binding.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            binding.MoveNext();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            binding.MoveLast();
        }

        private void modeLecture()
        {
            MODE_FORM = MODE_LECTURE;
            textBoxCode.Enabled = textBoxNom.Enabled =
                textBoxAdresse.Enabled = dateTimePickerInscription.Enabled = false;
            buttonNouveau.Text = "Nouveau";
            buttonModifier.Text = "Modifier";
            buttonSupprimer.Text = "Suppimer";
            buttonModifier.Enabled = true;
            buttonSupprimer.Enabled = true;
            buttonRechercher.Enabled = true;
        }

        private void modeAjout()
        {
            MODE_FORM = MODE_AJOUT;
           textBoxNom.Enabled =
                textBoxAdresse.Enabled = dateTimePickerInscription.Enabled = true;
            //Laisser le binding faire les modifs
            /* textBoxNom.Text =
               textBoxAdresse.Text = "";
            dateTimePickerInscription.Value = DateTime.Now;*/

            binding.AddNew();

            buttonNouveau.Text = "Ajouter";
            buttonModifier.Text = "Modifier";
            buttonSupprimer.Text = "Suppimer";
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonRechercher.Enabled = false;
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            if (MODE_FORM == MODE_LECTURE)
                modeAjout();
            else
            {
                //Operation d'ajout
                binding.EndEdit();
                modeLecture();
            }
        }
    }
}
