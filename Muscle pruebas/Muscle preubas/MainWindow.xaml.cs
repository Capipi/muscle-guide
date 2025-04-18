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

namespace Muscle_preubas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MostrarEtiqueta();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hola mundo desde WPF");
            var textEnvio = "Hola mundo desde WPF";
            var nuevaVentana = new Window1(textEnvio);
            nuevaVentana.Show();
        }

        //private void MostrarEtiqueta()
        //{
        //    lblTitle.Content = "Hola WPF";
        //    lblTitle.FontSize = 50;
        //    lblTitle.HorizontalAlignment = HorizontalAlignment.Center;
        //    lblTitle.VerticalAlignment = VerticalAlignment.Center;
        //}
    }
}
