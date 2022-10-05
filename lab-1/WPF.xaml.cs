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

namespace lab_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double r = 0, a = 0;
        public int n = 0;
        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void t2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void t3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            r = Convert.ToDouble(t1.Text);
            n = Convert.ToInt32(t2.Text);
            a = (2 * r * Math.Tan(Math.PI / n));
            t3.Text = (n * a).ToString();
        }

    }
}
