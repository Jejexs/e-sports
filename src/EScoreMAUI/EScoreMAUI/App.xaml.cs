using EScoreMAUI.Entity;

namespace EScoreMAUI
{
    public partial class App : Application
    {
        // Définissez une liste statique de joueurs accessible dans toute l'application
        public static List<Joueur> Joueurs { get; } = new List<Joueur>();

        // Définissez une liste statique de parties accessible dans toute l'application
        public static List<Partie> Parties { get; } = new List<Partie>();

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}