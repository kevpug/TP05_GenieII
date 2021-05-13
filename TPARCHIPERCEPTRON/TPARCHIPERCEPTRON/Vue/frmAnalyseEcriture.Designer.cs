using ControleUtilisateurPerceptron.Vue;

namespace TPARCHIPERCEPTRON
{
    partial class frmAnalyseEcriture
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.grpEntrainement = new System.Windows.Forms.GroupBox();
            this.lblValeurEntraine = new System.Windows.Forms.Label();
            this.txtValeurEntrainee = new System.Windows.Forms.TextBox();
            this.btnEntrainement = new System.Windows.Forms.Button();
            this.grpDessinEntrainement = new System.Windows.Forms.GroupBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.ucDessin = new ucZoneDessin();
            this.grpTests = new System.Windows.Forms.GroupBox();
            this.lblValeurTestee = new System.Windows.Forms.Label();
            this.txtValeurTestee = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.grpEntrainement.SuspendLayout();
            this.grpDessinEntrainement.SuspendLayout();
            this.grpTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 326);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(366, 185);
            this.txtConsole.TabIndex = 2;
            // 
            // grpEntrainement
            // 
            this.grpEntrainement.Controls.Add(this.lblValeurEntraine);
            this.grpEntrainement.Controls.Add(this.txtValeurEntrainee);
            this.grpEntrainement.Controls.Add(this.btnEntrainement);
            this.grpEntrainement.Location = new System.Drawing.Point(13, 156);
            this.grpEntrainement.Name = "grpEntrainement";
            this.grpEntrainement.Size = new System.Drawing.Size(365, 79);
            this.grpEntrainement.TabIndex = 5;
            this.grpEntrainement.TabStop = false;
            this.grpEntrainement.Text = "Entrainement";
            // 
            // lblValeurEntraine
            // 
            this.lblValeurEntraine.AutoSize = true;
            this.lblValeurEntraine.Location = new System.Drawing.Point(7, 40);
            this.lblValeurEntraine.Name = "lblValeurEntraine";
            this.lblValeurEntraine.Size = new System.Drawing.Size(90, 13);
            this.lblValeurEntraine.TabIndex = 3;
            this.lblValeurEntraine.Text = "Valeur entrainée :";
            // 
            // txtValeurEntrainee
            // 
            this.txtValeurEntrainee.Location = new System.Drawing.Point(103, 37);
            this.txtValeurEntrainee.Name = "txtValeurEntrainee";
            this.txtValeurEntrainee.Size = new System.Drawing.Size(100, 20);
            this.txtValeurEntrainee.TabIndex = 2;
            // 
            // btnEntrainement
            // 
            this.btnEntrainement.Location = new System.Drawing.Point(253, 20);
            this.btnEntrainement.Name = "btnEntrainement";
            this.btnEntrainement.Size = new System.Drawing.Size(106, 47);
            this.btnEntrainement.TabIndex = 1;
            this.btnEntrainement.Text = "Entrainement";
            this.btnEntrainement.UseVisualStyleBackColor = true;
            this.btnEntrainement.Click += new System.EventHandler(this.btnEntrainement_Click);
            // 
            // grpDessinEntrainement
            // 
            this.grpDessinEntrainement.Controls.Add(this.btnEffacer);
            this.grpDessinEntrainement.Controls.Add(this.ucDessin);
            this.grpDessinEntrainement.Location = new System.Drawing.Point(12, 12);
            this.grpDessinEntrainement.Name = "grpDessinEntrainement";
            this.grpDessinEntrainement.Size = new System.Drawing.Size(366, 138);
            this.grpDessinEntrainement.TabIndex = 4;
            this.grpDessinEntrainement.TabStop = false;
            this.grpDessinEntrainement.Text = "Zone de dessin";
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(268, 36);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 1;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // ucDessin
            // 
            this.ucDessin.BackColor = System.Drawing.Color.White;
            this.ucDessin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucDessin.Location = new System.Drawing.Point(148, 36);
            this.ucDessin.Name = "ucDessin";
            this.ucDessin.Size = new System.Drawing.Size(CstApplication.TAILLEDESSINX, CstApplication.TAILLEDESSINY);
            this.ucDessin.TabIndex = 0;
            // 
            // grpTests
            // 
            this.grpTests.Controls.Add(this.lblValeurTestee);
            this.grpTests.Controls.Add(this.txtValeurTestee);
            this.grpTests.Controls.Add(this.btnTest);
            this.grpTests.Location = new System.Drawing.Point(13, 241);
            this.grpTests.Name = "grpTests";
            this.grpTests.Size = new System.Drawing.Size(365, 79);
            this.grpTests.TabIndex = 6;
            this.grpTests.TabStop = false;
            this.grpTests.Text = "Tests";
            // 
            // lblValeurTestee
            // 
            this.lblValeurTestee.AutoSize = true;
            this.lblValeurTestee.Location = new System.Drawing.Point(7, 40);
            this.lblValeurTestee.Name = "lblValeurTestee";
            this.lblValeurTestee.Size = new System.Drawing.Size(75, 13);
            this.lblValeurTestee.TabIndex = 3;
            this.lblValeurTestee.Text = "Valeur testée :";
            // 
            // txtValeurTestee
            // 
            this.txtValeurTestee.Location = new System.Drawing.Point(103, 37);
            this.txtValeurTestee.Name = "txtValeurTestee";
            this.txtValeurTestee.ReadOnly = true;
            this.txtValeurTestee.Size = new System.Drawing.Size(100, 20);
            this.txtValeurTestee.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(253, 20);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(106, 47);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmAnalyseEcriture
            // 
            this.AcceptButton = this.btnEntrainement;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 519);
            this.Controls.Add(this.grpTests);
            this.Controls.Add(this.grpEntrainement);
            this.Controls.Add(this.grpDessinEntrainement);
            this.Controls.Add(this.txtConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAnalyseEcriture";
            this.Text = "Analyse Écriture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnalyseEcriture_FormClosing);
            this.grpEntrainement.ResumeLayout(false);
            this.grpEntrainement.PerformLayout();
            this.grpDessinEntrainement.ResumeLayout(false);
            this.grpTests.ResumeLayout(false);
            this.grpTests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.GroupBox grpEntrainement;
        private System.Windows.Forms.Label lblValeurEntraine;
        private System.Windows.Forms.TextBox txtValeurEntrainee;
        private System.Windows.Forms.Button btnEntrainement;
        private System.Windows.Forms.GroupBox grpDessinEntrainement;
        private ucZoneDessin ucDessin;
        private System.Windows.Forms.GroupBox grpTests;
        private System.Windows.Forms.Label lblValeurTestee;
        private System.Windows.Forms.TextBox txtValeurTestee;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnEffacer;
    }
}

