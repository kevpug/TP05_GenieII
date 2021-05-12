using System;
using System.Configuration;
using System.Windows.Forms;

namespace TPARCHIPERCEPTRON
{
    /// <summary>
    /// Permet d'afficher l'interface pour la reconnaissance de caractères. 
    /// Cet interface fera appel au Perceptron pour identifier le caractère dessiné.
    /// </summary>
    public partial class frmAnalyseEcriture : Form
    {

        private Metier.IGestionPerceptron _gcpAnalyseEcriture;
        private string _fichier = "";

        /// <summary>
        /// Constructeur de la form. Initialise les composants
        /// </summary>
        public frmAnalyseEcriture()
        {
            InitializeComponent();
            _fichier = ConfigurationManager.AppSettings["FichierApp"];
            _gcpAnalyseEcriture = new Metier.GestionClassesPerceptrons();
            ucDessin.Width = CstApplication.TAILLEDESSINX;
            ucDessin.Height = CstApplication.TAILLEDESSINY;
            _gcpAnalyseEcriture.ChargerCoordonnees(_fichier);
        }


        /// <summary>
        /// Entraine le bon Perceptron avec la valeur entrée dans le textBox txtValeurEntrainee et le caractère dessiné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrainement_Click(object sender, EventArgs e)
        {
            if (txtValeurEntrainee.Text == "")
                MessageBox.Show("Vous devez entrer au moins une valeur à faire apprendre.");
            else
            {
                txtConsole.Text = _gcpAnalyseEcriture.Entrainement(ucDessin.Coordonnees, txtValeurEntrainee.Text);
                //ucDessin.EffacerDessin();
            }
        }

        /// <summary>
        /// Appel le perceptron pour vérifier quel neuronne identifie le mieux le caractère dessiné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            txtValeurTestee.Text = _gcpAnalyseEcriture.TesterPerceptron(ucDessin.Coordonnees);
            txtConsole.Text = txtValeurTestee.Text;
        }

        /// <summary>
        /// Efface le caractère dessiné et sa matrice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            ucDessin.EffacerDessin();
        }

        /// <summary>
        /// Lors de la fermeture de la form, enregistré les données des perceptrons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAnalyseEcriture_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gcpAnalyseEcriture.SauvegarderCoordonnees(_fichier);
        }
    }
}
