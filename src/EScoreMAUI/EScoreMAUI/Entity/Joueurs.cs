using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EScoreMAUI
{
    public class Joueurs
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        
        public string Pseudo { get; set; }
        
        public string Equipe { get; set; }

        public Joueurs(int id, string nom, string prenom, string pseudo, string equipe)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Pseudo = pseudo;
            Equipe = equipe;
        }
    }
}
