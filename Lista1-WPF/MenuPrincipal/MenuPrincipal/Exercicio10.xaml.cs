using System;
using System.Windows;

namespace MenuPrincipal
{
    public partial class Exercicio10 : Window
    {
        private Random random = new Random();

        public Exercicio10()
        {
            InitializeComponent();
        }

        private void Sortear_Click(object sender, RoutedEventArgs e)
        {
            int numero = random.Next(1, 7); // 1 a 6

            if (numero == 6)
            {
                MessageBox.Show($"Número sorteado: {numero}\nVocê ganhou!", "Resultado");
            }
            else
            {
                MessageBox.Show($"Número sorteado: {numero}\nTente novamente!", "Resultado");
            }
        }
    }
}
