using System.Windows;

namespace UnitsConverter
{
    public partial class WeightConverter : Window
    {
        public WeightConverter()
        {
            InitializeComponent();
        }

        private void Retour_Click(object sender, RoutedEventArgs e) // Retourner à la fenêtre principale
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Fermer la fenêtre
        }

        private void Convertir_Click(object sender, RoutedEventArgs e) // Convertir le poids
        {
            double fromValue = double.Parse(FromValue.Text); // Lecture de la valeur
            double toValue = 0;

            if (FromUnit.Text == "Livre" && ToUnit.Text == "Kilogramme") // lb en kg
            {
                toValue = fromValue * 0.453592;
            }
            else if (FromUnit.Text == "Kilogramme" && ToUnit.Text == "Livre") // Kg en Lb
            {
                toValue = fromValue * 2.20462;
            }

            ToValue.Text = toValue.ToString(); // Affichage du résultat
        }
    }
}
