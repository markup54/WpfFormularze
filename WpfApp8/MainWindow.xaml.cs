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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float dlugoscrz = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Długość:"+dlugoscTextbox.Text);

            int dlugosc = 0;
            if (int.TryParse(dlugoscTextbox.Text,out dlugosc))
            {
                int pole = dlugosc * dlugosc;
                MessageBox.Show("Pole kwadratu wynosi: " + pole);
            }
            else
            {
                MessageBox.Show("podano niewłaściwe dane");
            }
            
            if(float.TryParse(dlugoscTextbox.Text,out dlugoscrz))
            {
                float polerz = dlugoscrz * dlugoscrz;
                MessageBox.Show("Pole kwadratu wynosi: " + polerz);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float pole = 0;
            if(kwadratradio.IsChecked == true)
            {
                pole = dlugoscrz * dlugoscrz;
            }
            else if(koloradio.IsChecked == true)
            {
                pole = (float) Math.PI * dlugoscrz*dlugoscrz;
            }
            else if(trojkatradio.IsChecked == true)
            {
                pole = (float)(dlugoscrz * dlugoscrz * Math.Sqrt(3)) / 4;
            }
            MessageBox.Show("Pole wybranej figury wynosi: " + pole);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int ile = 0;
            int suma = 0;
            if(liczba1.IsChecked == true)
            {
                suma = suma + 1;
                ile++;
            }
            if (liczba2.IsChecked == true)
            {
                suma = suma + 2;
                ile++;
            }
            if (liczba3.IsChecked == true)
            {
                suma = suma + 3;
                ile++;
            }
            if (liczba4.IsChecked == true)
            {
                suma = suma + 4;
                ile++;
            }
            if (liczba5.IsChecked == true)
            {
                suma = suma + 5;
                ile++;
            }
            if (liczba6.IsChecked == true)
            {
                suma = suma + 6;
                ile++;
            }
            double srednia = (double)suma / ile;
            MessageBox.Show("średnia: " + srednia);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            float obwod = 0;
            if(figuraComboBox.SelectedIndex == 0) {
                obwod = dlugoscrz * 4;
            }
            else if(figuraComboBox.SelectedIndex== 1)
            {
                obwod = (float)Math.PI * 2 * dlugoscrz;
            }
            else if(figuraComboBox.SelectedIndex == 2)
            {
                obwod = 3 * dlugoscrz;
            }
            MessageBox.Show("Obwód " + obwod);
        }
    }
}
