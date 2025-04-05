using System.Windows;

namespace UnitsConverter
{
    public partial class LengthConverter : Window
    {
        public LengthConverter()
        {
            InitializeComponent();
        }

        private void Retour_Click(object sender, RoutedEventArgs e) // Bouton retour
        {
            MainWindow mainWindow = new MainWindow(); // Ouvre la fenêtre principale
            mainWindow.Show();
            this.Close();
        }

        private void Convertir_Click(object sender, RoutedEventArgs e) //Creer le bouton 
        {
            double fromValue = double.Parse(FromValue.Text); // Lit la valeur entrée
            double toValue = 0;

            if (FromUnit.Text == "Mètre" && ToUnit.Text == "Kilomètre") // 
            {
                toValue = fromValue / 1000;
            }
            else if (FromUnit.Text == "Kilomètre" && ToUnit.Text == "Mètre") // Km en m
            {
                toValue = fromValue * 1000;
            }

            ToValue.Text = toValue.ToString(); // Affiche le résultat
        }
    }
}
