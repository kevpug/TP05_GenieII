using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUtilisateurPerceptron.Vue
{
    /// <summary>
    /// Auteur : Kévin Pugliese, Arnaud Labrecque
    /// Description: Interface pour le UI(ucEntrainement).
    /// Date: 2020-05-12
    /// </summary>
    public interface IucEntrainement
    {
        string CheminFichierEntrainement { get; set; }
        bool UtiliserNouveauFichier { get; set; }
        double ConstanteApprentissage { get; set; }
        CoordDessin Dessin { get;}
        string ValeurEntrainement { get; }

        event EventHandler EntrainementEvt;
        event EventHandler LoadEvt;

    }
}
