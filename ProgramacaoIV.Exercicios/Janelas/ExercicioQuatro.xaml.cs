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
    /// Lógica interna para ExercicioQuatro.xaml
    /// </summary>
    public partial class ExercicioQuatro : Window
    {
        public ExercicioQuatro()
        {
            InitializeComponent();
        }


        public void btnIdade_Click(object sender, RoutedEventArgs e)
        {
            //var idade = txtIdade.Text;

            // ele pega o valor que o ususario digitou verifica se o valor que o usuario digitou é inteiro, se for ele acrescenta 
            //na variavel idade e retorna verdadeiro
            //se for falso ele acrescenta 0 no valo da idade e cai e valor invalido
           if(! int.TryParse(txtIdade.Text, out int idade))

            {
                MessageBox.Show("Valor invalido.");
                return;

            }
            if (idade >= 18 )
            {
                MessageBox.Show("Maior de idade ");

            }
            else
            {
                MessageBox.Show("Menor de idade ");
            }

        }

       
    }
}
