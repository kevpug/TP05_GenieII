using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUtilisateurPerceptron.Vue
{
    public interface IucEcriture
    {

        string CheminFichierEntrainement { get; set; }
        bool modePhrase { get; set; }
        double ConstanteApprentissage { get; set; }
        string TextConsole { get;  set; }
        CoordDessin Dessin { get; }


        event EventHandler EcritureEvt;



    }
}
