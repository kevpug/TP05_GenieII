using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUtilisateurPerceptron.Vue
{
    /// <summary>
    /// Auteur : Kévin Pugliese, Arnaud Labrecque
    /// Description: Interface pour le UI(ucÉcriture).
    /// Date: 2020-05-12
    /// </summary>
    public interface IucEcriture
    {

        string CheminFichierEntrainement { get; set; }
        bool modePhrase { get; set; }
        double ConstanteApprentissage { get; set; }
        string TextConsole { get;  set; }
        CoordDessin Dessin { get; }


        event EventHandler EcritureEvt;
        event EventHandler SauvegardeEvt;





    }
}
