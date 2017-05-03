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
using System.Windows.Shapes;

namespace Karteiapp
{
    /// <summary>
    /// Interaktionslogik für Kartenansicht.xaml
    /// </summary>
    public partial class Kartenansicht : Window
    {
        int index;
        List<Karte> karte = new List<Karte>();
        public Kartenansicht()
        {

            karte.Add(new Karte {Frage = "Frage"});
            karte.Add(new Karte { Frage = "Antwort" });
            this.index = 0;
            this.DataContext = karte[this.index];
            InitializeComponent();
        }

        private void Schließen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Zeige_Antwort(object sender, RoutedEventArgs e)
        {
            this.DataContext = karte[++this.index];
        }
    }
}
