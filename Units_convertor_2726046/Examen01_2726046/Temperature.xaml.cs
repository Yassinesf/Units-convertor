using System.Windows;

namespace UnitsConverter
{
    public partial class TemperatureConverter : Window
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void Retour_Click(object sender, RoutedEventArgs e) // Retourner à la fenêtre principale
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Convertir_Click(object sender, RoutedEventArgs e) // Convertir température
        {
            double fromValue = double.Parse(FromValue.Text); // Lire la valeur entrée
            double toValue = 0;

            if (FromUnit.Text == "Celsius" && ToUnit.Text == "Fahrenheit") // C en F
            {
                toValue = (fromValue * 9 / 5) + 32;
            }
            else if (FromUnit.Text == "Fahrenheit" && ToUnit.Text == "Celsius") // F en C
            {
                toValue = (fromValue - 32) * 5 / 9;
            }

            ToValue.Text = toValue.ToString(); // Affichage
        }
    }
}
