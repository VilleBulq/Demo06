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

namespace App_01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CarsButton_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(CarstextBlock1.Text);
            value++;
            CarstextBlock1.Text =value.ToString();
        }

        private void TruckButton_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(TruckstextBlock.Text);
            value++;
            TruckstextBlock.Text = value.ToString();
        }
    }
}
