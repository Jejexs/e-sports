using System;

namespace EScoreMAUI.Entity
{
    public class Joueur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public string Equipe { get; set; } // Modifiez le type pour correspondre au nom de l'équipe

        public Joueur() // Ajoutez un constructeur par défaut pour la sérialisation
        {

        }

        public Joueur(int id, string nom, string prenom, string pseudo, string equipe)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Pseudo = pseudo;
            Equipe = equipe;
        }
    }
}