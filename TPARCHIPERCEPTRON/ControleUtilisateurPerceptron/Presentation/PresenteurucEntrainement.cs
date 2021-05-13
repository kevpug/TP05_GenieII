using ControleUtilisateurPerceptron.Modele;
using ControleUtilisateurPerceptron.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUtilisateurPerceptron.Presentation
{
    /// <summary>
    /// Auteur : Kévin Pugliese, Arnaud Labrecque
    /// Description: Classe qui s'occupe de faire la connection du UI(ucEntrainement) jusqu'au modele.
    /// Date: 2020-05-12
    /// </summary>
    class PresenteurucEntrainement
    {
        private IucEntrainement _vue;
        private GestionClassesPerceptrons _gestionClassesPerceptron;
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="vue"></param>
        public PresenteurucEntrainement(IucEntrainement vue)
        {
            _vue = vue;
            _vue.EntrainementEvt += Entrainement;
            _vue.LoadEvt += Load;
        }
        /// <summary>
        /// Execute le loading des perceptrons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load(object sender, EventArgs e)
        {
            //Logique pour que la valeur ne soit pas a 0.00...
            _gestionClassesPerceptron = new GestionClassesPerceptrons(_vue.ConstanteApprentissage == 0.00 ? 0.01 : _vue.ConstanteApprentissage);

            if (!_vue.UtiliserNouveauFichier)
                _gestionClassesPerceptron.ChargerCoordonnees(_vue.CheminFichierEntrainement);

        }

        /// <summary>
        /// Execute l'entraînement des perceptrons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entrainement(object sender, EventArgs e)
        {
            _gestionClassesPerceptron.Entrainement(_vue.Dessin, _vue.ValeurEntrainement);
        }

    }
}
