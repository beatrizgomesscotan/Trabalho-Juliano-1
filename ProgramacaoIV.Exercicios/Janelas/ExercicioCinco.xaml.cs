using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public enum TipoUsuario
    {
        [Description("Usuário com privilégios administrativos.")]
        Administrador,

        [Description("Usuário comum com acesso limitado.")]
        UsuarioComum,

        [Description("Usuário visitante com acesso restrito.")]
        Visitante
    }

    public partial class ExercicioCinco : Window
    {
        public ExercicioCinco()
        {
            InitializeComponent();
            PreencherComboBox();
        }

        private void PreencherComboBox()
        {
            // Preenche o ComboBox com os valores do Enum
            cbTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario)).Cast<TipoUsuario>();
            cbTipoUsuario.SelectedIndex = 0;
        }

        private void BtnExibirDescricao_Click(object sender, RoutedEventArgs e)
        {
            if (cbTipoUsuario.SelectedItem is TipoUsuario tipoSelecionado)
            {
                string descricao = ObterDescricao(tipoSelecionado);
                MessageBox.Show(descricao, "Descrição do Tipo de Usuário", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private string ObterDescricao(TipoUsuario tipo)
        {
            // Obtém a descrição do atributo [Description]
            FieldInfo field = tipo.GetType().GetField(tipo.ToString());

            if (field != null) // Verifica se o field não é nulo
            {
                DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                return attribute != null ? attribute.Description : tipo.ToString();
            }

            return tipo.ToString();
        }
    }
}
