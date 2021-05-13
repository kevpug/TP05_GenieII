using ControleUtilisateurPerceptron.Modele;
using ControleUtilisateurPerceptron.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUtilisateurPerceptron.Presentation
{
    class PresenteurucEntrainement
    {
        private IucEntrainement _vue;
        private GestionClassesPerceptrons _gestionClassesPerceptron;
        public PresenteurucEntrainement(IucEntrainement vue)
        {
            _vue = vue;
            //Logique pour que la valeur ne soit pas a 0.00...
            _vue.EntrainementEvt += Entrainement;
            _vue.LoadEvt += Load;
        }

        private void Load(object sender, EventArgs e)
        {
            _gestionClassesPerceptron = new GestionClassesPerceptrons(_vue.ConstanteApprentissage == 0.00 ? 0.01 : _vue.ConstanteApprentissage);

            if (!_vue.UtiliserNouveauFichier)
                _gestionClassesPerceptron.ChargerCoordonnees(_vue.CheminFichierEntrainement);

        }

        private void Entrainement(object sender, EventArgs e)
        {
            _gestionClassesPerceptron.Entrainement(_vue.Dessin, _vue.ValeurEntrainement);
        }

    }
}
