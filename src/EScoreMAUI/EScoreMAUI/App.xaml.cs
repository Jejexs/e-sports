﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using EScoreMAUI.Entity;
using Microsoft.Maui.Controls;

namespace EScoreMAUI
{
    public partial class App : Application
    {
        public static ObservableCollection<Joueur> Joueurs { get; } = new ObservableCollection<Joueur>();

        public static List<Partie> Parties { get; } = new List<Partie>();

        public static ObservableCollection<Equipe> Equipes { get; } = new ObservableCollection<Equipe>();

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}