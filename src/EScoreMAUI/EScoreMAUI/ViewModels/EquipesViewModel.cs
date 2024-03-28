using System.Collections.ObjectModel;
using EScoreMAUI.Entity;
using System.Linq;

namespace EScoreMAUI.ViewModels
{
    public class EquipesViewModel
    {
        public ObservableCollection<Equipe> Equipes { get; set; } = new ObservableCollection<Equipe>();

        public EquipesViewModel()
        {
            ChargerEquipes();
        }

        private void ChargerEquipes()
        {
            var equipesTemp = new List<Equipe>
            {
                new Equipe { ID = 1, NomEquipe = "Vitality", TauxDeVictoire = 75, Score = 100 },
                new Equipe { ID = 2, NomEquipe = "Gentle Mates", TauxDeVictoire = 90, Score = 200 },
                new Equipe { ID = 3, NomEquipe = "Karmine Corp", TauxDeVictoire = 50, Score = 180 },
                new Equipe { ID = 4, NomEquipe = "G2 Esports", TauxDeVictoire = 65, Score = 90 },
                new Equipe { ID = 5, NomEquipe = "LDLC OL", TauxDeVictoire = 55, Score = 120 },
                new Equipe { ID = 6, NomEquipe = "Misfits Gaming", TauxDeVictoire = 45, Score = 85 },
                new Equipe { ID = 7, NomEquipe = "Rogue Esports Club", TauxDeVictoire = 60, Score = 105 },
                new Equipe { ID = 8, NomEquipe = "Fnatic", TauxDeVictoire = 70, Score = 110 },
                new Equipe { ID = 9, NomEquipe = "Team Heretics", TauxDeVictoire = 40, Score = 95 },
                new Equipe { ID = 10, NomEquipe = "MAD Lions", TauxDeVictoire = 58, Score = 100 },
                new Equipe { ID = 11, NomEquipe = "Solary", TauxDeVictoire = 33, Score = 50 },

            };

            var equipesTrie = equipesTemp.OrderByDescending(e => e.Score).ToList();

            Equipes.Clear();

            int classement = 1;
            foreach (var equipe in equipesTrie)
            {
                equipe.Classement = classement++;
                Equipes.Add(equipe);
            }
        }
    }
}
