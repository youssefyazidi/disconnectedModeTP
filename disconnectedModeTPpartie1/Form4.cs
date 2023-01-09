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
            //textBoxCode.BackColor = Col;
            //textBoxCode.Font=new Font()
            textBoxCode.DataBindings.Add("Text", binding, "CodeA");
          //textBoxCode.DataBindings.Add("BackColor", binding, "couleur");
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

            buttonfirst.Enabled = buttonLast.Enabled = buttonNext.Enabled =
                buttonPrevious.Enabled = true;
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
            // binding.AddNew();

            buttonNouveau.Text = "Ajouter";
            buttonModifier.Text = "Modifier";
            buttonSupprimer.Text = "Suppimer";
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonRechercher.Enabled = false;

            buttonfirst.Enabled = buttonLast.Enabled = buttonNext.Enabled =
                buttonPrevious.Enabled = false;
        }


        private void modeModification()
        {
            MODE_FORM = MODE_MODIFICATIONN;
            textBoxNom.Enabled =
                 textBoxAdresse.Enabled = dateTimePickerInscription.Enabled = true;

            buttonNouveau.Text = "Nouveau";
            buttonModifier.Text = "Valider";
            buttonSupprimer.Text = "Suppimer";
            buttonModifier.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonRechercher.Enabled = false;

            buttonfirst.Enabled = buttonLast.Enabled = buttonNext.Enabled =
                buttonPrevious.Enabled = false;
        }
        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            if (MODE_FORM == MODE_LECTURE)
            {
                modeAjout();

                binding.AddNew();
            }
            else
            {
                //Operation d'ajout
                //Confirmer de l'edition
                binding.EndEdit();
                modeLecture();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            binding.CancelEdit();
            modeLecture();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if(MODE_FORM == MODE_LECTURE)
            {
                modeModification();
            }
            else if(MODE_FORM == MODE_MODIFICATIONN)
            {
                binding.EndEdit();
                modeLecture();
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Est ce que vous voulez supprimer ?"
                ,"Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes)
            {

                binding.RemoveAt(binding.Position);
            }
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            if (MODE_FORM != MODE_LECTURE)
            {
                return;
            }
            if(textBoxCodeRechercher.Text.Trim()=="")
            {
                MessageBox.Show("Vous devez saisir un code!");
                return;
            }

          int positionTrouver=binding.Find("CodeA", textBoxCodeRechercher.Text);
            if (positionTrouver == -1)
            {
                MessageBox.Show("Ce code n existe pas dans la base!");
                return;
            }
            binding.Position = positionTrouver;
           
        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Est ce que vous voulez enregistrer ?"
              , "Enregistrement...",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Envoyer les mise à jours vers la base 
                GestionDataSet.adherentAdapter.Update(ds.Tables["adherent"]);

                //Rendre les mise à jour définitives
                ds.AcceptChanges();
            }
        }
    }
}
