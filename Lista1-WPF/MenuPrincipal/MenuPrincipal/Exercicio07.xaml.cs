using System;
using System.Windows;

namespace MenuPrincipal
{
    public partial class Exercicio7 : Window
    {
        public Exercicio7()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                comboParcelas.Items.Add(i);
            }
            comboParcelas.SelectedIndex = 0;
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valorTotal = double.Parse(txtValorTotal.Text);
                int parcelas = (int)comboParcelas.SelectedItem;
                double valorParcela = valorTotal / parcelas;

                MessageBox.Show($"Cada parcela será de R$ {valorParcela:F2}", "Resultado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira um valor numérico válido no campo Valor Total.", "Erro");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro inesperado");
            }
        }
    }
}
