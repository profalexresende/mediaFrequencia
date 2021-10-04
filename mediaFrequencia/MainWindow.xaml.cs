using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mediaFrequencia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSituacao_Click(object sender, RoutedEventArgs e)
        {
            double nota1, nota2, aulasAssistidas, aulasDadas, media, freq;

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            aulasAssistidas = Convert.ToDouble(txtAulasAssistidas.Text);
            aulasDadas = Convert.ToDouble(txtTotalAulas.Text);

            media = (nota1 + nota2) / 2;
            freq = (aulasAssistidas / aulasDadas) * 100;

            if(media>=7 && freq >= 75)
            {
                MessageBox.Show("Aprovado!!!\nMédia: " + media.ToString("0.00") +
                    "\nFrequência: " + freq.ToString("0.00") + "%",
                    "Notas Escolares", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Retido!!!\nMédia: " + media.ToString("0.00") +
                    "\nFrequência: " + freq.ToString("0.00") + "%",
                    "Notas Escolares", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
