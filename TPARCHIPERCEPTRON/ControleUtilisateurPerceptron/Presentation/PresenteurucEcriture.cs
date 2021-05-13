using ControleUtilisateurPerceptron.Modele;
using ControleUtilisateurPerceptron.Vue;
using System;

namespace ControleUtilisateurPerceptron.Presentation
{
    /// <summary>
    /// Auteur : Kévin Pugliese, Arnaud Labrecque
    /// Description: Classe qui s'occupe de faire la connection du UI(ucÉcriture) jusqu'au modele.
    /// Date: 2020-05-12
    /// </summary>
    public class PresenteurucEcriture
    {
        private IucEcriture _vue;
        private GestionClassesPerceptrons _gestionClassesPerceptron;
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="vue"></param>
        public PresenteurucEcriture(IucEcriture vue)
        {
            _vue = vue;
            _gestionClassesPerceptron = new GestionClassesPerceptrons(_vue.ConstanteApprentissage);
            _vue.EcritureEvt += Ecriture;
            _vue.SauvegardeEvt += Sauvegarde;
        }
        /// <summary>
        /// Execute la sauvegarde de tous les perceptrons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sauvegarde(object sender, EventArgs e)
        {
            _gestionClassesPerceptron.SauvegarderCoordonnees(_vue.CheminFichierEntrainement);
        }
        /// <summary>
        /// Execute la recognition de texte pour un caractère.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ecriture(object sender, EventArgs e)
        {
            string sValeur = _gestionClassesPerceptron.TesterPerceptron(_vue.Dessin);
            if (sValeur == " " && _vue.modePhrase)
                _vue.TextConsole = "";
            else if (_vue.modePhrase)
                _vue.TextConsole += sValeur;
            else
                _vue.TextConsole = sValeur;
        }
    }
}
