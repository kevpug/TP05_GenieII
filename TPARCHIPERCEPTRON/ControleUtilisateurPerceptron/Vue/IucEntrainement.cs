using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUtilisateurPerceptron.Vue
{
    public interface IucEntrainement
    {
        public string Console { get; set; }
        public string NomFichier { get; }

        void Close();
        event EventHandler LectureFichierEvt;
        event EventHandler FermetureFenetreEvt;
    }
}
