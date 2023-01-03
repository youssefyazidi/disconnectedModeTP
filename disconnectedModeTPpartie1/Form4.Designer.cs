namespace disconnectedModeTPpartie1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.dateTimePickerInscription = new System.Windows.Forms.DateTimePicker();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCodeRechercher = new System.Windows.Forms.TextBox();
            this.buttonfirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.Rechercher.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code adherent :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Inscription :  ";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(199, 64);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(162, 21);
            this.textBoxCode.TabIndex = 5;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(199, 108);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(162, 21);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(199, 155);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(162, 21);
            this.textBoxAdresse.TabIndex = 7;
            // 
            // dateTimePickerInscription
            // 
            this.dateTimePickerInscription.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInscription.Location = new System.Drawing.Point(199, 203);
            this.dateTimePickerInscription.Name = "dateTimePickerInscription";
            this.dateTimePickerInscription.Size = new System.Drawing.Size(162, 21);
            this.dateTimePickerInscription.TabIndex = 8;
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(430, 59);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(159, 23);
            this.buttonNouveau.TabIndex = 9;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(430, 114);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(159, 23);
            this.buttonModifier.TabIndex = 10;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(430, 175);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(159, 23);
            this.buttonSupprimer.TabIndex = 11;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(97, 29);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(159, 23);
            this.buttonRechercher.TabIndex = 12;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(430, 347);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(159, 23);
            this.buttonQuitter.TabIndex = 13;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // Rechercher
            // 
            this.Rechercher.Controls.Add(this.textBoxCodeRechercher);
            this.Rechercher.Controls.Add(this.label5);
            this.Rechercher.Controls.Add(this.buttonRechercher);
            this.Rechercher.Location = new System.Drawing.Point(414, 223);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(262, 100);
            this.Rechercher.TabIndex = 14;
            this.Rechercher.TabStop = false;
            this.Rechercher.Text = "Recherche";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Code adherent :";
            // 
            // textBoxCodeRechercher
            // 
            this.textBoxCodeRechercher.Location = new System.Drawing.Point(114, 73);
            this.textBoxCodeRechercher.Name = "textBoxCodeRechercher";
            this.textBoxCodeRechercher.Size = new System.Drawing.Size(142, 21);
            this.textBoxCodeRechercher.TabIndex = 14;
            // 
            // buttonfirst
            // 
            this.buttonfirst.Location = new System.Drawing.Point(51, 268);
            this.buttonfirst.Name = "buttonfirst";
            this.buttonfirst.Size = new System.Drawing.Size(42, 23);
            this.buttonfirst.TabIndex = 15;
            this.buttonfirst.Text = "<<";
            this.buttonfirst.UseVisualStyleBackColor = true;
            this.buttonfirst.Click += new System.EventHandler(this.buttonfirst_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(115, 268);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(42, 23);
            this.buttonPrevious.TabIndex = 16;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(185, 268);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(42, 23);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(252, 268);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(42, 23);
            this.buttonLast.TabIndex = 18;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 382);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonfirst);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.dateTimePickerInscription);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form4";
            this.Text = "Gestion des adhrents";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Rechercher.ResumeLayout(false);
            this.Rechercher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.DateTimePicker dateTimePickerInscription;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.GroupBox Rechercher;
        private System.Windows.Forms.TextBox textBoxCodeRechercher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonfirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
    }
}