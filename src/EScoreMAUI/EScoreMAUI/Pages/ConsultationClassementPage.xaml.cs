using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace EScoreMAUI.Pages
{
    public partial class ConsultationClassementPage : ContentPage
    {
        public ConsultationClassementPage()
        {
            InitializeComponent();

            // Simulation de données de classement (remplacer par vos propres données)
            ObservableCollection<ClassementItem> classementItems = new ObservableCollection<ClassementItem>
            {
                new ClassementItem { Rang = 1, Nom = "Joueur 1", TauxVictoire = "80%", PointsTotal = 1500 },
                new ClassementItem { Rang = 2, Nom = "Joueur 2", TauxVictoire = "75%", PointsTotal = 1400 },
                new ClassementItem { Rang = 3, Nom = "Joueur 3", TauxVictoire = "70%", PointsTotal = 1300 }
            };

            ClassementListView.ItemsSource = classementItems;
        }
    }

    public class ClassementItem
    {
        public int Rang { get; set; }
        public string Nom { get; set; }
        public string TauxVictoire { get; set; }
        public int PointsTotal { get; set; }
    }
}