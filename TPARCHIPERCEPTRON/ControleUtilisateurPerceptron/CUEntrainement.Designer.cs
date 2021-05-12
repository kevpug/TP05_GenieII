namespace ControleUtilisateurPerceptron
{
    partial class CUEntrainement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucZoneDessin1 = new ControleUtilisateurPerceptron.ucZoneDessin();
            this.SuspendLayout();
            // 
            // ucZoneDessin1
            // 
            this.ucZoneDessin1.BackColor = System.Drawing.Color.White;
            this.ucZoneDessin1.Location = new System.Drawing.Point(75, 44);
            this.ucZoneDessin1.Name = "ucZoneDessin1";
            this.ucZoneDessin1.Size = new System.Drawing.Size(64, 64);
            this.ucZoneDessin1.TabIndex = 0;
            // 
            // CUEntrainement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucZoneDessin1);
            this.Name = "CUEntrainement";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private ucZoneDessin ucZoneDessin1;
    }
}
