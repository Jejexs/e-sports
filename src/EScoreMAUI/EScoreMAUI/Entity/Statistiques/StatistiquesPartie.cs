using System;

namespace EScoreMAUI.Entity.Statistiques
{
    // Entity des Statistiques de l'application où on retrouve les informations des statistiques de la partie
    public class StatistiquesPartie : Statistiques
    {
        public TimeSpan Duree { get; set; }
        public string Score { get; set; }
        public int NombreMatchsGagnes { get; set; }
        public int NombreMatchsPerdus { get; set; }
        public int NombreMatchsNuls { get; set; }
    }
}