using ControleUtilisateurPerceptron.Modele;
using ControleUtilisateurPerceptron.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUtilisateurPerceptron.Presentation
{
    public class PresenteurucEcriture
    {
        private IucEcriture _vue;
        private GestionClassesPerceptrons _gestionClassesPerceptron;

        public PresenteurucEcriture(IucEcriture vue)
        {
            _vue = vue;
            _gestionClassesPerceptron = new GestionClassesPerceptrons(_vue.ConstanteApprentissage);
            _vue.EcritureEvt += Ecriture;
        }

        private void Ecriture(object sender, EventArgs e)
        {
            string sValeur = _gestionClassesPerceptron.TesterPerceptron(_vue.Dessin);
            if(sValeur == " " && _vue.modePhrase)
                _vue.TextConsole = "";
            else if (_vue.modePhrase)
                _vue.TextConsole += sValeur;
            else
                _vue.TextConsole = sValeur;
        }
    }
}
