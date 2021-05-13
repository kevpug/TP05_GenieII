using ControleUtilisateurPerceptron.Presentation;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControleUtilisateurPerceptron.Vue
{
    /// <summary>
    /// Auteur : Kévin Pugliese, Arnaud Labrecque
    /// Description: User control qui s'occupe de faire la logique d'entrainement à la recognition de texte.
    /// Date: 2020-05-12
    /// </summary>
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
        public event EventHandler LoadEvt;
        /// <summary>
        /// ctor
        /// </summary>
        public ucEntrainement()
        {
            InitializeComponent();
            _presentateur = new PresenteurucEntrainement(this);
            ucDessin.Width = CstApplication.TAILLEDESSINX;
            ucDessin.Height = CstApplication.TAILLEDESSINY;

        }
        /// <summary>
        /// Execute l'action d'entraîner les perceptrons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrainement_Click(object sender, EventArgs e)
        {
            if (EntrainementEvt is object)
                EntrainementEvt(sender, e);
            ucDessin.EffacerDessin();

        }
        /// <summary>
        /// Reset le dessin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            ucDessin.EffacerDessin();
        }
        /// <summary>
        /// Lance l'action pour loader les perceptrons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucEntrainement_Load(object sender, EventArgs e)
        {
            if (LoadEvt is object)
                LoadEvt(sender, e);
        }
    }
}
