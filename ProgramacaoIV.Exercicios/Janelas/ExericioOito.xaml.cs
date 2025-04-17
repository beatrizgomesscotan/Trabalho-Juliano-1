using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExericioOito : Window
    {
        public ExericioOito()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate.HasValue)
            {
                DateTime selectedDate = datePicker.SelectedDate.Value;
                DiasSemana dia = (DiasSemana)selectedDate.DayOfWeek;
                MessageBox.Show($"O dia da semana é: {dia}", "Dia da Semana", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
