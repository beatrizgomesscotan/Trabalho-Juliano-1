using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioDez : Window
    {
        private Random random = new Random(); // Gerador de números aleatórios

        public ExercicioDez()
        {
            InitializeComponent();
        }

        private void Sorteio_Click(object sender, RoutedEventArgs e)
        {
            int numeroSorteado = random.Next(1, 7); // Gera um número entre 1 e 6
            MessageBox.Show($"Número sorteado: {numeroSorteado}", "Debug", MessageBoxButton.OK, MessageBoxImage.Information);

            string mensagem = numeroSorteado == 6 ? "Você ganhou!" : "Tente novamente!";
            MessageBox.Show(mensagem, "Resultado do Sorteio", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
