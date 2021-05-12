using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPARCHIPERCEPTRON.Metier
{
    /// <summary>
    /// Auteur :      Hugo St-Louis
    /// Description : Interface qui défini le comportement pour la gestion des perceptrons.
    /// Date :        2021-05-05
    /// </summary>
    interface IGestionPerceptron
    {
         void ChargerCoordonnees(string fichier);


       
         int SauvegarderCoordonnees(string fichier);

       
         string Entrainement(CoordDessin coordo, string reponse);


         string TesterPerceptron(CoordDessin coord);
    }
}
