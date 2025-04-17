using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimuladorParcelamento
{
    public partial class ExercicioSete : Window
    {
        public ExercicioSete()
        {
            InitializeComponent();
            PreencherParcelas();
        }

        private void PreencherParcelas()
        {
            // Adiciona opções de número de parcelas (1 a 24)
            for (int i = 1; i <= 24; i++)
            {
                cbParcelas.Items.Add(i);
            }
            cbParcelas.SelectedIndex = 0; // Define a opção inicial
        }

        private void BtnCalcularParcelas_Click(object sender, RoutedEventArgs e)
        {
            // Valida se o valor total é um número válido
            if (double.TryParse(txtValorTotal.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double valorTotal)
                && cbParcelas.SelectedItem is int numParcelas && numParcelas > 0)
            {
                double valorParcela = valorTotal / numParcelas;
                MessageBox.Show($"Valor de cada parcela: R$ {valorParcela:F2}",
                                "Resultado",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido e selecione uma quantidade de parcelas.",
                                "Erro",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

        private void ValidarEntradaNumerica(object sender, TextCompositionEventArgs e)
        {
            // Permite apenas números e ponto decimal
            e.Handled = !double.TryParse(((TextBox)sender).Text + e.Text, out _);
        }
    }
}
