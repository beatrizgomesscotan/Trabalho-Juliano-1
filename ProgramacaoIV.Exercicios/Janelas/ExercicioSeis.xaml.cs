using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioSeis : Window
    {
        private int contador = 0; // Variável para armazenar o número de cliques

        public ExercicioSeis()
        {
            InitializeComponent();
        }

        private void BtnContar_Click(object sender, RoutedEventArgs e)
        {
            contador++; // Incrementa o contador a cada clique
            MessageBox.Show($"Número de cliques: {contador}", "Contador", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
