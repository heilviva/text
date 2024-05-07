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
    /// Логика взаимодействия для Redactor.xaml
    /// </summary>
    public partial class Redactor : Window
    {
        private List<Gs> testii = new List<Gs>();
        public Redactor()
        {
            InitializeComponent();
            table.ItemsSource = testii;
        }

        private void add_que_Click(object sender, RoutedEventArgs e)
        {
            Saving.Serialize(testii.Count + 1);
            table.ItemsSource = null;
            table.ItemsSource = testii;
        }
        private void table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Saving.Serialize(testii);
        }
    }
}
    

