using System.Collections.ObjectModel;
using EScoreMAUI.Entity;
using System.Linq;

namespace EScoreMAUI.ViewModels
{
    public class JoueursViewModel
    {
        public ObservableCollection<Joueur> Joueurs { get; set; } = new ObservableCollection<Joueur>();

        public JoueursViewModel()
        {
            ChargerJoueurs();
        }

        private void ChargerJoueurs()
        {
            var joueursTemp = new List<Joueur>
            {
                new Joueur { ID = 1, Nom = "Alex Martin", Pseudo = "VIT_Alex", NomEquipe="Vitality", Score = 200, TauxDeVictoire = 80 },
                new Joueur { ID = 2, Nom = "Gabriel Petit", Pseudo = "GM_Gabriel", NomEquipe="Gentle Mates", Score = 210, TauxDeVictoire = 91 },
                new Joueur { ID = 3, Nom = "Lucie Bernard", Pseudo = "KC_Lucie", NomEquipe="Karmine Corp", Score = 190, TauxDeVictoire = 52 },
                new Joueur { ID = 4, Nom = "Émilie Leroy", Pseudo = "G2_Émilie", NomEquipe="G2 Esports", Score = 150, TauxDeVictoire = 66 },
                new Joueur { ID = 5, Nom = "Thomas Dupont", Pseudo = "LDLC_Thomas", NomEquipe="LDLC OL", Score = 130, TauxDeVictoire = 56 },
                new Joueur { ID = 6, Nom = "Charlotte Moreau", Pseudo = "MF_Charlotte", NomEquipe="Misfits Gaming", Score = 87, TauxDeVictoire = 46 },
                new Joueur { ID = 7, Nom = "Jules Lefebvre", Pseudo = "REC_Jules", NomEquipe="Rogue Esports Club", Score = 108, TauxDeVictoire = 61 },
                new Joueur { ID = 8, Nom = "Sophie Durand", Pseudo = "FNC_Sophie", NomEquipe="Fnatic", Score = 112, TauxDeVictoire = 71 },
                new Joueur { ID = 9, Nom = "Damien Roussel", Pseudo = "TH_Damien", NomEquipe="Team Heretics", Score = 97, TauxDeVictoire = 41 },
                new Joueur { ID = 10, Nom = "Marie David", Pseudo = "MAD_Marie", NomEquipe="MAD Lions", Score = 102, TauxDeVictoire = 59 },
                new Joueur { ID = 11, Nom = "Hugo Nguyen", Pseudo = "SLY_Hugo", NomEquipe="Solary", Score = 51, TauxDeVictoire = 34 }

            };

            
            var joueursTrie = joueursTemp.OrderByDescending(j => j.Score).ToList();

            Joueurs.Clear(); 
            int classement = 1;
            foreach (var joueur in joueursTrie)
            {
                joueur.Classement = classement++;
                Joueurs.Add(joueur);
            }
        }

    }
}
