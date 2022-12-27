namespace disconnectedModeTPpartie1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuteurs = new System.Windows.Forms.ComboBox();
            this.GrilleLivres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrilleLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auteurs :";
            // 
            // comboBoxAuteurs
            // 
            this.comboBoxAuteurs.FormattingEnabled = true;
            this.comboBoxAuteurs.Location = new System.Drawing.Point(123, 43);
            this.comboBoxAuteurs.Name = "comboBoxAuteurs";
            this.comboBoxAuteurs.Size = new System.Drawing.Size(275, 21);
            this.comboBoxAuteurs.TabIndex = 1;
            this.comboBoxAuteurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuteurs_SelectedIndexChanged);
            // 
            // GrilleLivres
            // 
            this.GrilleLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrilleLivres.Location = new System.Drawing.Point(34, 96);
            this.GrilleLivres.Name = "GrilleLivres";
            this.GrilleLivres.Size = new System.Drawing.Size(514, 150);
            this.GrilleLivres.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 279);
            this.Controls.Add(this.GrilleLivres);
            this.Controls.Add(this.comboBoxAuteurs);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrilleLivres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAuteurs;
        private System.Windows.Forms.DataGridView GrilleLivres;
    }
}