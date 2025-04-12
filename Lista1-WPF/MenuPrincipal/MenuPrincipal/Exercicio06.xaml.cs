using System;
using System.Windows;

namespace MenuPrincipal
{
    public partial class Exercicio6 : Window
    {
        private int contador = 0;

        public Exercicio6()
        {
            InitializeComponent();
        }

        private void ContarClique_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            MessageBox.Show($"Você clicou {contador} vez(es)!", "Contador");
        }
    }
}
