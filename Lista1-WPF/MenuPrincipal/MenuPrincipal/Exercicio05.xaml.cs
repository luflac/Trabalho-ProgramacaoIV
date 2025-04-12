using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;

namespace MenuPrincipal
{
    public enum TipoUsuario
    {
        [Description("Usuário com permissões administrativas")]
        Administrador,

        [Description("Usuário padrão do sistema")]
        UsuarioComum,

        [Description("Acesso limitado, visitante")]
        Visitante
    }

    public partial class Exercicio5 : Window
    {
        public Exercicio5()
        {
            InitializeComponent();
            comboUsuarios.ItemsSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private void ExibirDescricao_Click(object sender, RoutedEventArgs e)
        {
            if (comboUsuarios.SelectedItem is TipoUsuario tipo)
            {
                string descricao = ObterDescricaoEnum(tipo);
                MessageBox.Show(descricao, "Descrição do Tipo de Usuário");
            }
            else
            {
                MessageBox.Show("Selecione um tipo de usuário.", "Atenção");
            }
        }

        private string ObterDescricaoEnum(Enum valor)
        {
            FieldInfo campo = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute atributo = (DescriptionAttribute)Attribute.GetCustomAttribute(campo, typeof(DescriptionAttribute));

            return atributo != null ? atributo.Description : valor.ToString();
        }
    }
}
