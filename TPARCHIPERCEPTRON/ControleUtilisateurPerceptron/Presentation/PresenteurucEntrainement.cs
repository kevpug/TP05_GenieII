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
            _vue.EntrainementEvt += Entrainement;
            _gestionClassesPerceptron = new GestionClassesPerceptrons();
        }

        private void Entrainement(object sender, EventArgs e)
        {
            _gestionClassesPerceptron.Entrainement(_vue.Dessin, _vue.ValeurEntrainement);
        }
    }
}
