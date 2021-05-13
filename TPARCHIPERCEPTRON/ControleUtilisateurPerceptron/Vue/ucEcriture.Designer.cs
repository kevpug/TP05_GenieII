
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
            this.ucDessin = new ControleUtilisateurPerceptron.Vue.ucZoneDessin();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEcriture = new System.Windows.Forms.TextBox();
            this.grpDessin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDessin
            // 
            this.grpDessin.Controls.Add(this.ucDessin);
            this.grpDessin.Location = new System.Drawing.Point(12, 15);
            this.grpDessin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDessin.Name = "grpDessin";
            this.grpDessin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDessin.Size = new System.Drawing.Size(97, 126);
            this.grpDessin.TabIndex = 1;
            this.grpDessin.TabStop = false;
            this.grpDessin.Text = "Zone de dessin";
            // 
            // ucDessin
            // 
            this.ucDessin.BackColor = System.Drawing.Color.White;
            this.ucDessin.Location = new System.Drawing.Point(15, 32);
            this.ucDessin.Name = "ucDessin";
            this.ucDessin.Size = new System.Drawing.Size(64, 64);
            this.ucDessin.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(124, 15);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(136, 39);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtEcriture
            // 
            this.txtEcriture.BackColor = System.Drawing.Color.White;
            this.txtEcriture.Location = new System.Drawing.Point(12, 154);
            this.txtEcriture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEcriture.Multiline = true;
            this.txtEcriture.Name = "txtEcriture";
            this.txtEcriture.Size = new System.Drawing.Size(249, 78);
            this.txtEcriture.TabIndex = 3;
            // 
            // ucEcriture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEcriture);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpDessin);
            this.Name = "ucEcriture";
            this.Size = new System.Drawing.Size(278, 247);
            this.grpDessin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucZoneDessin ucDessin;
        private System.Windows.Forms.GroupBox grpDessin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtEcriture;
    }
}
