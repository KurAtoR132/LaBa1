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

namespace LaBa1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Answer.Clear();
            double a, V, S;
            if (!double.TryParse(NumberA.Text, out a))
            {
                MessageBox.Show("ТЫ ВООБЩЕ УМНЫЙ?");

            }
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 2);
            Answer.Text += $"V = {V}\nS={S}";
        }
    }
}
