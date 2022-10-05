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

        public string num;
        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void t3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            num = Convert.ToString(t1.Text); 
            if (num.Length == 3)
            {
                byte a = 1;
                double n1 = double.Parse(num[0].ToString());
                double n2 = double.Parse(num[1].ToString());
                double n3 = double.Parse(num[2].ToString());
                if (n3 - a == n2)
                {
                    if (n2 - a == n1)
                    {
                        t3.Text = (true).ToString();
                    }
                    else { t3.Text = (false).ToString(); }
                }
                else { t3.Text = (false).ToString(); }
            }
        }

    }
}
