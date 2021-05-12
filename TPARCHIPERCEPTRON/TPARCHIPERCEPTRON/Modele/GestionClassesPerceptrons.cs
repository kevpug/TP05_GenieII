﻿using ControleUtilisateurPerceptron;
using System.Collections.Generic;

namespace TPARCHIPERCEPTRON.Modele
{
    /// <summary>
    /// Gère les fonctionnalités de l'application. Entre autre, permet de :
    /// - Charger les échantillons d'apprentissage,
    /// - Sauvegarder les échantillons d'apprentissage,
    /// - Tester le perceptron
    /// - Entrainer le perceptron
    /// </summary>
    public class GestionClassesPerceptrons : IGestionPerceptron
    {
        private Dictionary<string, Perceptron> _lstPerceptrons;
        private List<CoordDessin> _lstCoordonnes;
        private IGestionFichiers _gestionFichiers;

        /// <summary>
        /// Constructeur
        /// </summary>
        public GestionClassesPerceptrons()
        {
            _lstPerceptrons = new Dictionary<string, Perceptron>();
            _lstCoordonnes = new List<CoordDessin>();
            _gestionFichiers = new GestionFichiersSorties();
        }

        /// <summary>
        /// Charge les échantillons d'apprentissage sauvegardé sur le disque.
        /// </summary>
        /// <param name="fichier">Le nom du fichier</param>
        public void ChargerCoordonnees(string fichier)
        {
            _lstCoordonnes = _gestionFichiers.ChargerCoordonnees(fichier);
            foreach (CoordDessin c in _lstCoordonnes)
                if (_lstPerceptrons.ContainsKey(c.Reponse) == false)
                    _lstPerceptrons.Add(c.Reponse, new Perceptron(c.Reponse));

            foreach (Perceptron p in _lstPerceptrons.Values)
                p.Entrainement(_lstCoordonnes);
        }

        /// <summary>
        /// Sauvegarde les échantillons d'apprentissage sauvegardé sur le disque.
        /// </summary>
        /// <param name="fichier">Le nom du fichier</param>
        /// <returns>En cas d'erreur retourne le code d'erreur</returns>
        public int SauvegarderCoordonnees(string fichier)
        {
            int erreur = CstApplication.ERREUR;
            erreur = _gestionFichiers.SauvegarderCoordonnees(fichier, _lstCoordonnes);
            return erreur;
        }

        /// <summary>
        /// Entraine les perceptrons avec un nouveau caractère
        /// </summary>
        /// <param name="coordo">Les nouvelles coordonnées</param>
        /// <param name="reponse">La réponse associé(caractère) aux coordonnées</param>
        /// <returns>Le résultat de la console</returns>
        public string Entrainement(CoordDessin coordo, string reponse)
        {
            string sConsole = "";
            if (_lstPerceptrons.ContainsKey(reponse) == false)
                _lstPerceptrons.Add(reponse, new Perceptron(reponse));
            coordo.Reponse = reponse;
            _lstCoordonnes.Add(coordo);
            
            foreach (Perceptron p in _lstPerceptrons.Values)
                sConsole+= p.Entrainement(_lstCoordonnes);

            return sConsole;
        }


        /// <summary>
        /// Test le perceptron avec de nouvelles coordonnées.
        /// </summary>
        /// <param name="coord">Les nouvelles coordonnées</param>
        /// <returns>Retourne la liste des valeurs possibles du perceptron</returns>
        public string TesterPerceptron(CoordDessin coord)
        {
            string resultat = "";
            bool valeur;
            
            foreach (Perceptron p in _lstPerceptrons.Values)
            {
                valeur = p.TesterNeurone(coord);
                if (valeur)
                    resultat += p.Reponse;
            }

            if (resultat == "")
                resultat = "?";

            return resultat;
        }
    }
}
