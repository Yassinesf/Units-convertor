using System.Windows;

namespace UnitsConverter
{
    public partial class VolumeConverter : Window
    {
        public VolumeConverter()
        {
            InitializeComponent();
        }

        private void Retour_Click(object sender, RoutedEventArgs e) // Retourner à la fenêtre principale
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Convertir_Click(object sender, RoutedEventArgs e) // Convertir le volume
        {
            double fromValue = double.Parse(FromValue.Text); // Lire la valeur entrée
            double toValue = 0;

            if (FromUnit.Text == "Litre" && ToUnit.Text == "Gallon") //  litre en gallon
            {
                toValue = fromValue * 0.264172;
            }
            else if (FromUnit.Text == "Gallon" && ToUnit.Text == "Litre") // gallon en litre
            {
                toValue = fromValue * 3.78541;
            }

            ToValue.Text = toValue.ToString();
        }
    }
}
