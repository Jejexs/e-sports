using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EScoreMAUI.Entity
{
    public class Joueur
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Pseudo { get; set; }
        public double Score { get; set; }
        public string NomEquipe { get; set; }

        public double TauxDeVictoire { get; set; }
        public int Classement { get; set; }

        public string NomEtPseudo => $"{Nom} - {Pseudo}";
    }
}

