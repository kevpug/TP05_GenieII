using ControleUtilisateurPerceptron.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleUtilisateurPerceptron.Vue
{
    public partial class ucEcriture : UserControl, IucEcriture
    {
        private string _cheminFichierEntrainement = "";
        private bool _modePhrase;
        private double _constanteApprentissage;
        private PresenteurucEcriture _presentateur;


        [Category("Parametre Ecriture")]
        public string CheminFichierEntrainement 
        { get { return _cheminFichierEntrainement; }
            set { _cheminFichierEntrainement = value; }
        }

        [Category("Parametre Ecriture")]
        public bool modePhrase 
        { get { return _modePhrase; }
            set { _modePhrase = value; } 
        }

        [Category("Parametre Ecriture")]
        public double ConstanteApprentissage
        { get { return _constanteApprentissage; }
            set { _constanteApprentissage = value; } 
        }

        public ucEcriture()
        {
            InitializeComponent();
            _presentateur = new PresenteurucEcriture(this);
        }
    }
}
