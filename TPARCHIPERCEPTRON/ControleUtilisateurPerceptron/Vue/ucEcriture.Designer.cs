
namespace ControleUtilisateurPerceptron.Vue
{
    partial class ucEcriture
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
            this.grpDessin = new System.Windows.Forms.GroupBox();
            this.ucZoneDessin1 = new ucZoneDessin();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEcriture = new System.Windows.Forms.TextBox();
            this.grpDessin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDessin
            // 
            this.grpDessin.Controls.Add(this.ucZoneDessin1);
            this.grpDessin.Location = new System.Drawing.Point(16, 19);
            this.grpDessin.Name = "grpDessin";
            this.grpDessin.Size = new System.Drawing.Size(129, 155);
            this.grpDessin.TabIndex = 1;
            this.grpDessin.TabStop = false;
            this.grpDessin.Text = "Zone de dessin";
            // 
            // ucZoneDessin1
            // 
            this.ucZoneDessin1.BackColor = System.Drawing.Color.White;
            this.ucZoneDessin1.Location = new System.Drawing.Point(20, 39);
            this.ucZoneDessin1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucZoneDessin1.Name = "ucZoneDessin1";
            this.ucZoneDessin1.Size = new System.Drawing.Size(85, 79);
            this.ucZoneDessin1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(165, 19);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(182, 48);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtEcriture
            // 
            this.txtEcriture.BackColor = System.Drawing.Color.White;
            this.txtEcriture.Location = new System.Drawing.Point(16, 190);
            this.txtEcriture.Multiline = true;
            this.txtEcriture.Name = "txtEcriture";
            this.txtEcriture.Size = new System.Drawing.Size(331, 95);
            this.txtEcriture.TabIndex = 3;
            // 
            // ucEcriture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEcriture);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpDessin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucEcriture";
            this.Size = new System.Drawing.Size(371, 304);
            this.grpDessin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucZoneDessin ucZoneDessin1;
        private System.Windows.Forms.GroupBox grpDessin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtEcriture;
    }
}
