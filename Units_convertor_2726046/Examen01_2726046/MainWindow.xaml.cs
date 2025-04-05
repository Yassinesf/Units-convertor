using System.Windows;

namespace UnitsConverter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Volumes_Click(object sender, RoutedEventArgs e) // Bouton volume
        {
            VolumeConverter volumeConverter = new VolumeConverter();
            volumeConverter.Show();
            this.Close(); // Fermer la fenêtre
        }

        private void Longueurs_Click(object sender, RoutedEventArgs e) // Bouton longueur
        {
            LengthConverter lengthConverter = new LengthConverter();
            lengthConverter.Show();
            this.Close(); // Fermer la fenêtre
        }

        private void Temperatures_Click(object sender, RoutedEventArgs e) // Bouton température
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            temperatureConverter.Show();
            this.Close(); // Fermer la fenêtre
        }

        private void Poids_Click(object sender, RoutedEventArgs e) // Bouton poids
        {
            WeightConverter weightConverter = new WeightConverter(); // Ouvrir WeightConverter
            weightConverter.Show();
            this.Close(); // Fermer la fenêtre
        }
    }
}
