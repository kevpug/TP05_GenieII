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
            this.ucDessin = new ControleUtilisateurPerceptron.Vue.ucZoneDessin();
            this.lblValeur = new System.Windows.Forms.Label();
            this.btnEntrainement = new System.Windows.Forms.Button();
            this.txtEntrainement = new System.Windows.Forms.TextBox();
            this.grpZoneDessin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpZoneDessin
            // 
            this.grpZoneDessin.Controls.Add(this.btnEffacer);
            this.grpZoneDessin.Controls.Add(this.ucDessin);
            this.grpZoneDessin.Location = new System.Drawing.Point(36, 34);
            this.grpZoneDessin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpZoneDessin.Name = "grpZoneDessin";
            this.grpZoneDessin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpZoneDessin.Size = new System.Drawing.Size(260, 172);
            this.grpZoneDessin.TabIndex = 0;
            this.grpZoneDessin.TabStop = false;
            this.grpZoneDessin.Text = "Zone de dessin";
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(101, 41);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(141, 37);
            this.btnEffacer.TabIndex = 1;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // ucDessin
            // 
            this.ucDessin.BackColor = System.Drawing.Color.White;
            this.ucDessin.Location = new System.Drawing.Point(8, 41);
            this.ucDessin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucDessin.Name = "ucDessin";
            this.ucDessin.Size = new System.Drawing.Size(85, 79);
            this.ucDessin.TabIndex = 0;
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(327, 49);
            this.lblValeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(121, 17);
            this.lblValeur.TabIndex = 1;
            this.lblValeur.Text = "Valeur entrainée :";
            // 
            // btnEntrainement
            // 
            this.btnEntrainement.Location = new System.Drawing.Point(455, 89);
            this.btnEntrainement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrainement.Name = "btnEntrainement";
            this.btnEntrainement.Size = new System.Drawing.Size(177, 53);
            this.btnEntrainement.TabIndex = 2;
            this.btnEntrainement.Text = "Entrainement";
            this.btnEntrainement.UseVisualStyleBackColor = true;
            this.btnEntrainement.Click += new System.EventHandler(this.btnEntrainement_Click);
            // 
            // txtEntrainement
            // 
            this.txtEntrainement.Location = new System.Drawing.Point(455, 46);
            this.txtEntrainement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntrainement.Name = "txtEntrainement";
            this.txtEntrainement.Size = new System.Drawing.Size(176, 22);
            this.txtEntrainement.TabIndex = 3;
            // 
            // ucEntrainement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEntrainement);
            this.Controls.Add(this.btnEntrainement);
            this.Controls.Add(this.lblValeur);
            this.Controls.Add(this.grpZoneDessin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucEntrainement";
            this.Size = new System.Drawing.Size(677, 247);
            this.grpZoneDessin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpZoneDessin;
        private System.Windows.Forms.Button btnEffacer;
        private ucZoneDessin ucDessin;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.Button btnEntrainement;
        private System.Windows.Forms.TextBox txtEntrainement;
    }
}
