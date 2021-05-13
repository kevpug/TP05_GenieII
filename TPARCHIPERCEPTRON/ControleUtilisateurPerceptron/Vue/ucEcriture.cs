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

        public event EventHandler EcritureEvt;
        public event EventHandler SauvegardeEvt;
        public event EventHandler LoadEvt;
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

        public ucEcriture()
        {
            InitializeComponent();
            _presentateur = new PresenteurucEcriture(this);
            ucDessin.Width = CstApplication.TAILLEDESSINX;
            ucDessin.Height = CstApplication.TAILLEDESSINY;
        }

        private void _mainOwner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SauvegardeEvt is object)
                SauvegardeEvt(sender, e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (EcritureEvt is object)
                EcritureEvt(sender, e);
            ucDessin.EffacerDessin();
        }

        private void ucEcriture_Load(object sender, EventArgs e)
        {
            _mainOwner = FindForm();
            _mainOwner.FormClosing += _mainOwner_FormClosing;

        }
    }
}
