using System;
using System.Windows;
using System.Windows.Controls;

namespace muscle_try
{
    public partial class PaginaCalculadora : Page
    {
        public PaginaCalculadora()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            // Validación básica (todos los campos escritos en tipo de dato correcto y no nulos)
            if (!double.TryParse(PesoInput.Text, out double peso) ||
                !double.TryParse(AlturaInput.Text, out double alturaCm) ||
                !int.TryParse(EdadInput.Text, out int edad) ||
                SexoCombo.SelectedItem == null ||
                ActividadCombo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            double alturaM = alturaCm / 100.0;

            // 1. Calcular IMC (2 decimales)
            double imc = peso / (alturaM * alturaM);
            ResultadoIMC.Text = $"IMC: {imc:F2}         <---¡No tiene en cuenta la masa muscular ni corporal!";
            
            // 2. Calcular TasaMetabólicaBasal (Mifflin-St Jeor) según hombre o mujer
            string sexo = ((ComboBoxItem)SexoCombo.SelectedItem).Content.ToString(); // No hay problema con esta alerta porque valido antes (if)
            double tmb;

            if (sexo == "Hombre")
                tmb = 10 * peso + 6.25 * alturaCm - 5 * edad + 5;
            else
                tmb = 10 * peso + 6.25 * alturaCm - 5 * edad - 161;

            // 3. Ajustar por nivel de actividad (quema de calorías)
            string actividad = ((ComboBoxItem)ActividadCombo.SelectedItem).Content.ToString(); // No hay problema con esta alerta porque valido antes (if)
            double factorActividad = actividad switch
            {
                string s when s.Contains("Sedentario") => 1.2, // Diferentes posibilidades
                string s when s.Contains("Ligero") => 1.375,
                string s when s.Contains("Moderado") => 1.55,
                string s when s.Contains("Activo") => 1.725,
                string s when s.Contains("Muy activo") => 1.9,
                _ => 1.2 // Else, o default (si no se selecciona algún anterior se pone este[aquí no haría falta])
            };

            double calorias = tmb * factorActividad;
            ResultadoCalorias.Text = $"Calorías estimadas: {calorias:F0} kcal/día";

            // 4. Macronutrientes (ejemplo: 2g proteína/kg, 25% grasas, resto carbos)
            double proteinas = peso * 2; // g/día
            double caloriasProteinas = proteinas * 4;

            double grasas = (calorias * 0.25) / 9; // g/día
            double caloriasGrasas = grasas * 9;

            double caloriasCarbos = calorias - (caloriasProteinas + caloriasGrasas);
            double carbohidratos = caloriasCarbos / 4;

            // Muestra los resultado formateados
            ResultadoMacros.Text = $"Macronutrientes estimados:\n" +
                                   $"- Proteínas: {proteinas:F0}g\n" +
                                   $"- Grasas: {grasas:F0}g\n" +
                                   $"- Carbohidratos: {carbohidratos:F0}g";
        }
    }
}
