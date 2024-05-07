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

namespace text
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void edit_test_Click(object sender, RoutedEventArgs e)
        {
            code.Visibility = Visibility.Visible;
        }

        private void code_TextChanged(object sender, RoutedEventArgs e)
        {
            string rez = code.Text;

            if (code.Text == "Winx")
            {
                Window1 test = new Window1(rez);
                test.ShowDialog();
            }
        }

        private void start_test_Click(object sender, RoutedEventArgs e)
        {
            string rez = code.Text;
            Window1 tester = new Window1(rez);
            tester.ShowDialog();
        }
    }
}
