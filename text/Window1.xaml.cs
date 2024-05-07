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

namespace text
{
    /// <summary>
    /// Логика взаимодействия для Window.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            edit_test_button.IsEnabled = rez == "liza";
        }

        private void start_test_button_Click(object sender, RoutedEventArgs e)
        {
            List<Gs> tests = Saving.Deserialize<List<Gs>>();
            if (tests == null)
            {
                pages.Content = new Winx();
            }
            else
            {
                pages.Content = new Test();
            }
        }

        private void edit_test_button_Click(object sender, RoutedEventArgs e)
        {

            pages.Content = new Redactor();
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}

