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

namespace Teht_03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        private double tempEurot;
        private double tempMarkat;
        private string tempString;
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void button_Click_markat_euroiksi(System.Object sender, RoutedEventArgs e)
        {
            tempString = markatBox.Text;
            tempEurot = double.Parse(tempString);
            tempEurot = tempEurot / 5.94573;
            eurotBox.Text = tempEurot.ToString("0.00");

        }

        private void button1_Click_eurot_markoiksi(System.Object sender, RoutedEventArgs e)
        {
            tempString = eurot2Box.Text;
            tempMarkat = double.Parse(tempString);
            tempMarkat = tempMarkat * 5.94573;
            markat2Box.Text = tempMarkat.ToString("0.00");
        }
    }
}
