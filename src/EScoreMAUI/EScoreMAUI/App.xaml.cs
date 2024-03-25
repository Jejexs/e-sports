using EScoreMAUI.Entity;

namespace EScoreMAUI
{
    public partial class App : Application
    {
        public static List<Joueur> Joueurs { get; } = new List<Joueur>();

        public static List<Partie> Parties { get; } = new List<Partie>();
        
        public static List<Equipe> Equipes { get; } = new List<Equipe>();

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}