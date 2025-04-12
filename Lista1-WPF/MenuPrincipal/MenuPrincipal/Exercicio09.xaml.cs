using System;
using System.Windows;

namespace MenuPrincipal
{
    public partial class Exercicio9 : Window
    {
        private bool ligado = false;

        public Exercicio9()
        {
            InitializeComponent();
        }

        private void AlternarEstado_Click(object sender, RoutedEventArgs e)
        {
            ligado = !ligado;

            string estado = ligado ? "Ligado" : "Desligado";
            MessageBox.Show($"O estado atual é: {estado}", "Interruptor");
        }
    }
}
