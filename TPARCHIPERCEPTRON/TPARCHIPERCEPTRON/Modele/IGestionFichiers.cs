using ControleUtilisateurPerceptron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPARCHIPERCEPTRON.Modele
{
    /// <summary>
    /// Auteur :      Hugo St-Louis
    /// Description : Interface pour la gestion de fichier
    /// Date :        2021-05-05
    /// </summary>
    public interface IGestionFichiers
    {
        List<CoordDessin> ChargerCoordonnees(string fichier);
        int SauvegarderCoordonnees(string fichier, List<CoordDessin> lstCoord);

    }
}
