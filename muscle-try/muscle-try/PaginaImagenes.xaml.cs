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

        // Todos los métodos que en el nombre tienen la palabra "Click" están asociados a "MouseDown",
        // es decir, cada vez que se pulse el ratón se ejecutan.
        // Lo que hacen es lo siguiente:
        // 1- Cambia el texto del título con el nombre del músculo.
        // 2- Asigna un video según el músculo al elemento "MediaElement", llamado "VideoMusculo".
        // 3- Cambia la propiedad "Visibility" del panel informativo (PanelMusculo) para que se vea.
        // 4- Reproduce el video

        private void Pecho_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Pectoral";
            VideoMusculo.Source = new Uri("videos/Pectoral.mp4", UriKind.Relative);
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
            TituloMusculo.Text = "Triceps";
            VideoMusculo.Source = new Uri("videos/Flexiones.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        private void Cuadriceps_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Cuádriceps";
            VideoMusculo.Source = new Uri("videos/Cuadriceps.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        private void HombrosFrente_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Deltoides anterior";
            VideoMusculo.Source = new Uri("videos/Deltoides_anterior.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        private void HombrosEspalda_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Deltoides medial";
            VideoMusculo.Source = new Uri("videos/Deltoides_medial.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        private void Torso_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Abdominales";
            VideoMusculo.Source = new Uri("videos/Plancha.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        private void Isquios_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TituloMusculo.Text = "Isquiotibiales";
            VideoMusculo.Source = new Uri("videos/Isquiotibiales.mp4", UriKind.Relative);
            PanelMusculo.Visibility = Visibility.Visible;
            VideoMusculo.Play();
        }

        // MouseEnter / MouseLeave
        // Estos métodos gestionana la entrada y salida del ratón en los polígonos:
        // Cuando entra se pone el borde (Stroke) de un color y aumenta su grosor (StrokeThickness) de 0 a 5
        // en su salida, vuelve a poner el grosor a 0

        //Parte general
        private void Polygon_MouseEnter(object sender, MouseEventArgs e)
        {
            var poligono = sender as Polygon;
            if (poligono != null)
            {
                poligono.StrokeThickness = 5;
                poligono.Stroke = Brushes.Blue;
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

        //Parte izquierda(frente)
        private void HombrosFrente_MouseEnter(object sender, MouseEventArgs e)
        {
            HombroIzquierdoFrente.Stroke = Brushes.Orange;
            HombroDerechoFrente.Stroke = Brushes.Orange;
            HombroIzquierdoFrente.StrokeThickness = 5;
            HombroDerechoFrente.StrokeThickness = 5;
        }

        private void HombrosFrente_MouseLeave(object sender, MouseEventArgs e)
        {
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
            BrazoIzquierdoEspalda.StrokeThickness = 0;
            BrazoDerechoEspalda.StrokeThickness = 0;
        }
    }
}
