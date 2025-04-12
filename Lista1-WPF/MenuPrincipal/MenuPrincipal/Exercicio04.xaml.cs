using System;
using System.Windows;

namespace MenuPrincipal
{
    public partial class Exercicio4 : Window
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idade = int.Parse(txtIdade.Text);

                if (idade >= 18)
                {
                    MessageBox.Show("Maior de idade", "Resultado");
                }
                else
                {
                    MessageBox.Show("Menor de idade", "Resultado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira uma idade válida (número inteiro).", "Erro");
            }
        }
    }
}
