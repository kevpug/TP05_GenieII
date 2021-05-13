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
        public PresenteurucEcriture(IucEcriture vue)
        {
            _vue = vue;
           // _vue.EntrainementEvt += Entrainement;
        }
    }
}
