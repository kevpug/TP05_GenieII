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
        public PresenteurucEntrainement(IucEntrainement vue)
        {
            _vue = vue;
            _vue.EntrainementEvt += Entrainement;
        }

        private void Entrainement(object sender, EventArgs e)
        {
        }
    }
}
