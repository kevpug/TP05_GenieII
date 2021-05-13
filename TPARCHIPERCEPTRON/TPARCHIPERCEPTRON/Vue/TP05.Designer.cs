
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
            this.ucEntrainement1 = new ControleUtilisateurPerceptron.Vue.ucEntrainement();
            this.ucEcriture1 = new ControleUtilisateurPerceptron.Vue.ucEcriture();
            this.SuspendLayout();
            // 
            // ucEntrainement1
            // 
            this.ucEntrainement1.CheminFichierEntrainement = "";
            this.ucEntrainement1.ConstanteApprentissage = 0D;
            this.ucEntrainement1.Location = new System.Drawing.Point(13, 3);
            this.ucEntrainement1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucEntrainement1.Name = "ucEntrainement1";
            this.ucEntrainement1.Size = new System.Drawing.Size(677, 247);
            this.ucEntrainement1.TabIndex = 0;
            this.ucEntrainement1.UtiliserNouveauFichier = false;
            // 
            // ucEcriture1
            // 
            this.ucEcriture1.CheminFichierEntrainement = "";
            this.ucEcriture1.ConstanteApprentissage = 0D;
            this.ucEcriture1.Location = new System.Drawing.Point(25, 240);
            this.ucEcriture1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucEcriture1.modePhrase = false;
            this.ucEcriture1.Name = "ucEcriture1";
            this.ucEcriture1.Size = new System.Drawing.Size(371, 304);
            this.ucEcriture1.TabIndex = 1;
            this.ucEcriture1.TextConsole = "";
            // 
            // TP05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 545);
            this.Controls.Add(this.ucEcriture1);
            this.Controls.Add(this.ucEntrainement1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TP05";
            this.Text = "Analyse écriture";
            this.ResumeLayout(false);

        }

        #endregion

        private ControleUtilisateurPerceptron.Vue.ucEntrainement ucEntrainement1;
        private ControleUtilisateurPerceptron.Vue.ucEcriture ucEcriture1;
    }
}