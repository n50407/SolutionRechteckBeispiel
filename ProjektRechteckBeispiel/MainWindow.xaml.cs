
using ProjektRechteckBeispiel.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektRechteckBeispiel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Baut den visuellen Tree auf - Textboxen, Buttons, Labels, etc.
            InitializeComponent();

            //Danach DatenKontext setzen

            Rechteck meinRechteck = 
                new Rechteck() { Laenge=200, Breite=400, Farbe="Red"};

            //Datenkontext setzen
            this.DataContext = meinRechteck;


        }
    }
}
