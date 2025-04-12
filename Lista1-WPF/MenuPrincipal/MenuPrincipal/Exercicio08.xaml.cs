using System;
using System.Windows;

namespace MenuPrincipal
{
    public enum DiasDaSemana
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }

    public partial class Exercicio8 : Window
    {
        public Exercicio8()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, RoutedEventArgs e)
        {
            if (dateSelecionada.SelectedDate.HasValue)
            {
                DateTime data = dateSelecionada.SelectedDate.Value;
                DiasDaSemana diaEnum = (DiasDaSemana)data.DayOfWeek;

                MessageBox.Show($"O dia da semana é: {diaEnum}", "Resultado");
            }
            else
            {
                MessageBox.Show("Selecione uma data.", "Erro");
            }
        }
    }
}
