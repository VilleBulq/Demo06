using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht_02
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public int korkeus;
        public int leveys;
        public int karmi;
        public int pintala;
        public int lasinpa;
        public int piiri;
        public MainPage()
        {
           
            
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           korkeus = int.Parse(Korkeus.Text);
           leveys = int.Parse(Leveys.Text);
           karmi = int.Parse(Karmi.Text);

           pintala = korkeus * leveys;
           lasinpa = (leveys - 2 * karmi) * (korkeus - 2 * karmi);
           piiri = leveys * 2 + korkeus * 2;
           Lasi.Text = lasinpa.ToString();
           Pinta.Text = pintala.ToString();
           Piiri.Text = piiri.ToString();
           
        }
        private void pinta_TextChanged(object sender, RoutedEventArgs e)
        {

        }
        private void piiri_TextChanged(object sender, RoutedEventArgs e) { }
    }
}
