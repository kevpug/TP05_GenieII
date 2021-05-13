using System;
using System.Windows.Forms;

namespace TPARCHIPERCEPTRON.Vue
{
    /// <summary>
    /// Auteur : Kévin Pugliese, Arnaud Labrecque
    /// Description: Affichage principal de l'application qui acceuille les 2 user controls.
    /// Date: 2020-05-12
    /// </summary>
    public partial class TP05 : Form
    {
        public TP05()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Méthode qui peut ajouter des traitements supplémentaires au bouton d'entrainement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucEntrainement1_EntrainementEvt(object sender, EventArgs e)
        {
            //Code supplémentaire au besoin traitement bouton entrainement...
        }
        /// <summary>
        /// Event de la fermeture du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TP05_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
