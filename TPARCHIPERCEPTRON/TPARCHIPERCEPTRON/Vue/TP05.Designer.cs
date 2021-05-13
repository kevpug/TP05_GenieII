
namespace TPARCHIPERCEPTRON.Vue
{
    partial class TP05
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucEcriture1 = new ControleUtilisateurPerceptron.Vue.ucEcriture();
            this.ucEntrainement1 = new ControleUtilisateurPerceptron.Vue.ucEntrainement();
            this.SuspendLayout();
            // 
            // ucEcriture1
            // 
            this.ucEcriture1.CheminFichierEntrainement = "../FichierEntrainement.dat";
            this.ucEcriture1.ConstanteApprentissage = 0.01D;
            this.ucEcriture1.Location = new System.Drawing.Point(19, 195);
            this.ucEcriture1.modePhrase = true;
            this.ucEcriture1.Name = "ucEcriture1";
            this.ucEcriture1.Size = new System.Drawing.Size(278, 247);
            this.ucEcriture1.TabIndex = 1;
            this.ucEcriture1.TextConsole = "";
            // 
            // ucEntrainement1
            // 
            this.ucEntrainement1.CheminFichierEntrainement = "../FichierEntrainement.dat";
            this.ucEntrainement1.ConstanteApprentissage = 0.01D;
            this.ucEntrainement1.Location = new System.Drawing.Point(10, 2);
            this.ucEntrainement1.Name = "ucEntrainement1";
            this.ucEntrainement1.Size = new System.Drawing.Size(508, 201);
            this.ucEntrainement1.TabIndex = 0;
            this.ucEntrainement1.UtiliserNouveauFichier = false;
            this.ucEntrainement1.EntrainementEvt += new System.EventHandler(this.ucEntrainement1_EntrainementEvt);
            // 
            // TP05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 443);
            this.Controls.Add(this.ucEcriture1);
            this.Controls.Add(this.ucEntrainement1);
            this.Name = "TP05";
            this.Text = "Analyse écriture";
            this.ResumeLayout(false);

        }

        #endregion

        private ControleUtilisateurPerceptron.Vue.ucEntrainement ucEntrainement1;
        private ControleUtilisateurPerceptron.Vue.ucEcriture ucEcriture1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}