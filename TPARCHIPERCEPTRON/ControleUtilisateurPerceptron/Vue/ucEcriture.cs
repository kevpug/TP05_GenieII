using ControleUtilisateurPerceptron.Presentation;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControleUtilisateurPerceptron.Vue
{
    /// <summary>
    /// Auteur : Kévin Pugliese, Arnaud Labrecque
    /// Description: User control qui s'occupe de faire la logique de recognition de texte.
    /// Date: 2020-05-12
    /// </summary>
    public partial class ucEcriture : UserControl, IucEcriture
    {
        private string _cheminFichierEntrainement = "";
        private bool _modePhrase;
        private double _constanteApprentissage;
        private PresenteurucEcriture _presentateur;

        public event EventHandler EcritureEvt;
        public event EventHandler SauvegardeEvt;
        Form _mainOwner;

        [Category("Parametre Ecriture")]
        public string CheminFichierEntrainement
        {
            get { return _cheminFichierEntrainement; }
            set { _cheminFichierEntrainement = value; }
        }

        [Category("Parametre Ecriture")]
        public bool modePhrase
        {
            get { return _modePhrase; }
            set { _modePhrase = value; }
        }

        [Category("Parametre Ecriture")]
        public double ConstanteApprentissage
        {
            get { return _constanteApprentissage; }
            set { _constanteApprentissage = value; }
        }

        public string TextConsole { get => txtEcriture.Text; set => txtEcriture.Text = value; }

        public CoordDessin Dessin => ucDessin.Coordonnees;
        /// <summary>
        /// ctor
        /// </summary>
        public ucEcriture()
        {
            InitializeComponent();
            _presentateur = new PresenteurucEcriture(this);
            ucDessin.Width = CstApplication.TAILLEDESSINX;
            ucDessin.Height = CstApplication.TAILLEDESSINY;
        }

        /// <summary>
        /// Quand le form parent se ferme, un évènement de sauvegarde s'execute.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _mainOwner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SauvegardeEvt is object)
                SauvegardeEvt(sender, e);
        }

        /// <summary>
        /// Sert à lancer la recognition de lettre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (EcritureEvt is object)
                EcritureEvt(sender, e);
            ucDessin.EffacerDessin();
        }

        /// <summary>
        /// On load event; va chercher le form owner et créer un evenement formclosing pour celui-ci.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucEcriture_Load(object sender, EventArgs e)
        {
            _mainOwner = FindForm();
            _mainOwner.FormClosing += _mainOwner_FormClosing;

        }
    }
}
