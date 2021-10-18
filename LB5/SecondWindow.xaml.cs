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

namespace LB5
{
    /// <summary>
    /// Логика взаимодействия для SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox1.Style = (Style)Resources["SubTextBox"];
            TextBox2.Style = (Style)Resources["SubTextBox"];
            TextBox3.Style = (Style)Resources["SubTextBox"];
            (sender as TextBox).Style = (Style)Resources["MainTextBox"];
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox1.Style = (Style)Resources["SubTextBox"];
            TextBox2.Style = (Style)Resources["SubTextBox"];
            TextBox4.Style = (Style)Resources["SubTextBox"];
            (sender as TextBox).Style = (Style)Resources["MainTextBox"];
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox1.Style = (Style)Resources["SubTextBox"];
            TextBox3.Style = (Style)Resources["SubTextBox"];
            TextBox4.Style = (Style)Resources["SubTextBox"];
            (sender as TextBox).Style = (Style)Resources["MainTextBox"];
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox2.Style = (Style)Resources["SubTextBox"];
            TextBox3.Style = (Style)Resources["SubTextBox"];
            TextBox4.Style = (Style)Resources["SubTextBox"];
            (sender as TextBox).Style = (Style)Resources["MainTextBox"];
        }
    }
}
