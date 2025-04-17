using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioNove : Window
    {
        private bool estadoLigado = false;

        public ExercicioNove()
        {
            InitializeComponent();
        }

        private void OnToggleClick(object sender, RoutedEventArgs e)
        {
            estadoLigado = !estadoLigado;
            string estado = estadoLigado ? "Ligado" : "Desligado";
            toggleButton.Content = estado;
            MessageBox.Show($"O estado atual é: {estado}", "Estado", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}