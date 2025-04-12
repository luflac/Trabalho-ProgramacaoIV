using System;
using System.Windows;

namespace MenuPrincipal
{

    public partial class Exercicio1 : Window
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void Somar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNumero1.Text);
                int num2 = int.Parse(txtNumero2.Text);
                int resultado = num1 + num2;

                MessageBox.Show($"A soma é: {resultado}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Digite dois números inteiros válidos.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
