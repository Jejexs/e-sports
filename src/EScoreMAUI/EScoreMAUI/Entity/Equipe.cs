using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EScoreMAUI.Entity
{
    public class Equipe
    {
        public int ID { get; set; }
        public string NomEquipe { get; set; }
        public int NombreDeMatchsJoues { get; set; }
        public double TauxDeVictoire { get; set; }
        public int Score { get; set; }
        public int Classement { get; set; }
    }
}
