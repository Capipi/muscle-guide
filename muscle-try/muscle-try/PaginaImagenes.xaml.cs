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
            VideoMusculo.Source = new Uri("videos/Flexiones.mp4", UriKind.Relative);
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

        private void Biceps_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Biceps";
            VideoMusculo.Source = new Uri("videos/Curl_biceps.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        private void Triceps_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Pecho";
            VideoMusculo.Source = new Uri("videos/Flexiones.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        private void Cuadriceps_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Cuádriceps";
            VideoMusculo.Source = new Uri("videos/Sentadilla.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        private void HombrosEspalda_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Laterales";
            VideoMusculo.Source = new Uri("videos/Laterales.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        //Parte general
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

        //Parte izquierda (frente)
        private void HombrosFrente_MouseEnter(object sender, MouseEventArgs e)
        {
            HombroIzquierdoFrente.Stroke = Brushes.Orange;
            HombroDerechoFrente.Stroke = Brushes.Orange;
            HombroIzquierdoFrente.StrokeThickness = 5;
            HombroDerechoFrente.StrokeThickness = 5;
        }

        private void HombrosFrente_MouseLeave(object sender, MouseEventArgs e)
        {
            HombroIzquierdoFrente.Stroke = Brushes.Red;
            HombroDerechoFrente.Stroke = Brushes.Red;
            HombroIzquierdoFrente.StrokeThickness = 0;
            HombroDerechoFrente.StrokeThickness = 0;
        }


        private void BrazosFrente_MouseEnter(object sender, MouseEventArgs e)
        {
            BrazoIzquierdoFrente.Stroke = Brushes.Orange;
            BrazoDerechoFrente.Stroke = Brushes.Orange;
            BrazoIzquierdoFrente.StrokeThickness = 5;
            BrazoDerechoFrente.StrokeThickness = 5;
        }

        private void BrazosFrente_MouseLeave(object sender, MouseEventArgs e)
        {
            BrazoIzquierdoFrente.Stroke = Brushes.Red;
            BrazoDerechoFrente.Stroke = Brushes.Red;
            BrazoIzquierdoFrente.StrokeThickness = 0;
            BrazoDerechoFrente.StrokeThickness = 0;
        }

        //Parte derecha (Espalda)
        private void HombrosEspalda_MouseEnter(object sender, MouseEventArgs e)
        {
            HombroIzquierdoEspalda.Stroke = Brushes.Orange;
            HombroDerechoEspalda.Stroke = Brushes.Orange;
            HombroIzquierdoEspalda.StrokeThickness = 5;
            HombroDerechoEspalda.StrokeThickness = 5;
        }

        private void HombrosEspalda_MouseLeave(object sender, MouseEventArgs e)
        {
            HombroIzquierdoEspalda.Stroke = Brushes.Red;
            HombroDerechoEspalda.Stroke = Brushes.Red;
            HombroIzquierdoEspalda.StrokeThickness = 0;
            HombroDerechoEspalda.StrokeThickness = 0;
        }


        private void BrazosEspalda_MouseEnter(object sender, MouseEventArgs e)
        {
            BrazoIzquierdoEspalda.Stroke = Brushes.Orange;
            BrazoDerechoEspalda.Stroke = Brushes.Orange;
            BrazoIzquierdoEspalda.StrokeThickness = 5;
            BrazoDerechoEspalda.StrokeThickness = 5;
        }

        private void BrazosEspalda_MouseLeave(object sender, MouseEventArgs e)
        {
            BrazoIzquierdoEspalda.Stroke = Brushes.Red;
            BrazoDerechoEspalda.Stroke = Brushes.Red;
            BrazoIzquierdoEspalda.StrokeThickness = 0;
            BrazoDerechoEspalda.StrokeThickness = 0;
        }
    }
}
