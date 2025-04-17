using System;
using System.Windows;
using System.Windows.Controls;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioTres.xaml
    /// </summary>
    public partial class ExercicioTres : Window
    {
        public ExercicioTres()
        {
            InitializeComponent();
        }

        public void btnAniversario_Click(object sender, RoutedEventArgs e)
        {
            // Verifica se o usuário selecionou uma data no DatePicker
            if (pegaDataNiver.SelectedDate.HasValue)
            {
                DateTime dataNascimento = pegaDataNiver.SelectedDate.Value; // Obtém a data de nascimento
                DateTime hoje = DateTime.Today; // Obtém a data atual da máquina

                // Define o próximo aniversário com base na data de nascimento
                DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

                // Se o aniversário já passou neste ano, calcula para o ano seguinte
                if (proximoAniversario < hoje)
                {
                    proximoAniversario = proximoAniversario.AddYears(1);
                }

                // Calcula a diferença de dias até o próximo aniversário
                int diasFaltantes = (proximoAniversario - hoje).Days;

                // Exibe o resultado em um MessageBox
                MessageBox.Show($"Faltam {diasFaltantes} dias para o seu próximo aniversário! 🎉",
                                "Contagem Regressiva",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            else
            {
                // Mensagem de erro caso o usuário não selecione uma data
                MessageBox.Show("Por favor, selecione uma data de nascimento válida.",
                                "Erro",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }
    }
}
