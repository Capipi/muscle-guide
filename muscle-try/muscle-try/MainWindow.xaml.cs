using muscle_try;
using System.Windows;
using System.Windows.Controls;

namespace ProyectoFinCurso
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Imagenes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PaginaImagenes());
        }

        private void Calculadora_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PaginaCalculadora());
        }
    }
}
