namespace ControleUtilisateurPerceptron.Vue
{
    partial class ucEntrainement
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
            this.grpZoneDessin = new System.Windows.Forms.GroupBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.ucZoneDessin1 = new ucZoneDessin();
            this.lblValeur = new System.Windows.Forms.Label();
            this.btnEntrainement = new System.Windows.Forms.Button();
            this.txtEntrainement = new System.Windows.Forms.TextBox();
            this.grpZoneDessin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpZoneDessin
            // 
            this.grpZoneDessin.Controls.Add(this.btnEffacer);
            this.grpZoneDessin.Controls.Add(this.ucZoneDessin1);
            this.grpZoneDessin.Location = new System.Drawing.Point(27, 28);
            this.grpZoneDessin.Name = "grpZoneDessin";
            this.grpZoneDessin.Size = new System.Drawing.Size(195, 140);
            this.grpZoneDessin.TabIndex = 0;
            this.grpZoneDessin.TabStop = false;
            this.grpZoneDessin.Text = "Zone de dessin";
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(76, 33);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(106, 30);
            this.btnEffacer.TabIndex = 1;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            // 
            // ucZoneDessin1
            // 
            this.ucZoneDessin1.BackColor = System.Drawing.Color.White;
            this.ucZoneDessin1.Location = new System.Drawing.Point(6, 33);
            this.ucZoneDessin1.Name = "ucZoneDessin1";
            this.ucZoneDessin1.Size = new System.Drawing.Size(64, 64);
            this.ucZoneDessin1.TabIndex = 0;
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(245, 40);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(90, 13);
            this.lblValeur.TabIndex = 1;
            this.lblValeur.Text = "Valeur entrainée :";
            // 
            // btnEntrainement
            // 
            this.btnEntrainement.Location = new System.Drawing.Point(341, 72);
            this.btnEntrainement.Name = "btnEntrainement";
            this.btnEntrainement.Size = new System.Drawing.Size(133, 43);
            this.btnEntrainement.TabIndex = 2;
            this.btnEntrainement.Text = "Entrainement";
            this.btnEntrainement.UseVisualStyleBackColor = true;
            // 
            // txtEntrainement
            // 
            this.txtEntrainement.Location = new System.Drawing.Point(341, 37);
            this.txtEntrainement.Name = "txtEntrainement";
            this.txtEntrainement.Size = new System.Drawing.Size(133, 20);
            this.txtEntrainement.TabIndex = 3;
            // 
            // ucEntrainement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEntrainement);
            this.Controls.Add(this.btnEntrainement);
            this.Controls.Add(this.lblValeur);
            this.Controls.Add(this.grpZoneDessin);
            this.Name = "ucEntrainement";
            this.Size = new System.Drawing.Size(508, 201);
            this.grpZoneDessin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpZoneDessin;
        private System.Windows.Forms.Button btnEffacer;
        private ucZoneDessin ucZoneDessin1;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.Button btnEntrainement;
        private System.Windows.Forms.TextBox txtEntrainement;
    }
}
