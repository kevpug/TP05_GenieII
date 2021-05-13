using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUtilisateurPerceptron.Vue
{
    public interface IucEntrainement
    {
        string CheminFichierEntrainement { get; set; }
        bool UtiliserNouveauFichier { get; set; }
        double ConstanteApprentissage { get; set; }
        CoordDessin Dessin { get;}
        string ValeurEntrainement { get; }

        event EventHandler EntrainementEvt;
    }
}
