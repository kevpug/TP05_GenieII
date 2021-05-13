using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleUtilisateurPerceptron.Presentation;

namespace ControleUtilisateurPerceptron.Vue
{
    public partial class ucEntrainement : UserControl, IucEntrainement
    {
        private string _cheminFichierEntrainement = "";
        private bool _utiliserNouveauFichier;
        private double _constanteApprentissage;
        private PresenteurucEntrainement _presentateur;

        [Category("Parametre Entrainement")]
        public string CheminFichierEntrainement
        {
            get
            {
                return _cheminFichierEntrainement;
            }
            set
            {
                _cheminFichierEntrainement = value;
            }
        }
        [Category("Parametre Entrainement")]
        public bool UtiliserNouveauFichier
        {
            get
            {
                return _utiliserNouveauFichier;
            }
            set
            {
                _utiliserNouveauFichier = value;
            }
        }

        [Category("Parametre Entrainement")]
        public double ConstanteApprentissage
        {
            get
            {
                return _constanteApprentissage;
            }
            set
            {
                _constanteApprentissage = value;
            }
        }

        public CoordDessin Dessin { get => ucDessin.Coordonnees; }
        public string ValeurEntrainement { get => txtEntrainement.Text; }

        [Category("Entrainement Events")]
        public event EventHandler EntrainementEvt;

        public ucEntrainement()
        {
            InitializeComponent();
            _presentateur = new PresenteurucEntrainement(this);
            ucDessin.Width = CstApplication.TAILLEDESSINX;
            ucDessin.Height = CstApplication.TAILLEDESSINY;

        }

        private void btnEntrainement_Click(object sender, EventArgs e)
        {
            if (EntrainementEvt is object)
                EntrainementEvt(sender, e);
            ucDessin.EffacerDessin();

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            ucDessin.EffacerDessin();
        }
    }
}
