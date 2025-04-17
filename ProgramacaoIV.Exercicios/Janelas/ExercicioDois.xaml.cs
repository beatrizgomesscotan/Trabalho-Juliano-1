using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioDois.xaml
    /// </summary>
    public partial class ExercicioDois : Window
    {
        public ExercicioDois()
        {
            InitializeComponent();
        }


        private void btnConversorTemperatura_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var valorCelsius = Convert.ToDouble(txtValorCelsius.Text);

                var fahrenheit = (valorCelsius * 9 / 5) + 32;

                MessageBox.Show($"Resultado = {fahrenheit}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtValorCelsius_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
