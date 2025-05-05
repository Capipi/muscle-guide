using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace muscle_try
{
    public partial class PaginaImagenes : Page
    {
        public PaginaImagenes()
        {
            InitializeComponent();
        }
        private void Pecho_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Pecho";
            VideoMusculo.Source = new Uri("videos/pecho.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }


        private void Espalda_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Espalda";
            VideoMusculo.Source = new Uri("videos/Flexiones.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
            //MessageBox.Show(System.IO.File.Exists("videos/pecho.mp4") ? "Sí existe" : "No existe");

        }

        private void Polygon_MouseEnter(object sender, MouseEventArgs e)
        {
            var poligono = sender as Polygon;
            if (poligono != null)
            {
                poligono.StrokeThickness = 5;
                poligono.Stroke = Brushes.LightBlue;
            }
        }

        private void Polygon_MouseLeave(object sender, MouseEventArgs e)
        {
            var poligono = sender as Polygon;
            if (poligono != null)
            {
                poligono.StrokeThickness = 0;
            }
        }
    }
}
