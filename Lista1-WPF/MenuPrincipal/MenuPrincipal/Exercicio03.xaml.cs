using System;
using System.Windows;

namespace MenuPrincipal
{
    public partial class Exercicio3 : Window
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            if (dateNascimento.SelectedDate.HasValue)
            {
                DateTime nascimento = dateNascimento.SelectedDate.Value;
                DateTime hoje = DateTime.Today;
                DateTime proximoAniversario = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);

                if (proximoAniversario < hoje)
                {
                    proximoAniversario = proximoAniversario.AddYears(1);
                }

                int diasFaltando = (proximoAniversario - hoje).Days;
                MessageBox.Show($"Faltam {diasFaltando} dia(s) para o seu aniversário!", "Resultado");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data de nascimento.", "Erro");
            }
        }
    }
}
