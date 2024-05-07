using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

    /// Логика взаимодействия для Test.xaml 
    public partial class Test : Window
    {
        private int num_of_que = 0;
        private int right_answers = 0;

        private List<Gs> tests = new List<Gs>();
        private List<string> variable_positive = new List<string> { "Первый" };
        private List<string> variable_not = new List<string> { "Второй" };
        public Test()
        {
            InitializeComponent();

            DisplayQuestion();
        }

        private void answer_1_button_Click(object sender, RoutedEventArgs e) => CheckAnswer(Enum.vop1);
        private void answer_2_button_Click(object sender, RoutedEventArgs e) => CheckAnswer(Enum.vop2);

        private void DisplayQuestion()
        {
            tests = Saving.Deserialize<List<Gs>>();

            if (tests != null)
            {
                if (tests.Count > num_of_que)
                {
                    var currentQuestion = tests[num_of_que];
                    _title.Text = currentQuestion.title;
                    _describe.Text = currentQuestion.describe;
                    answer_1_button.Content = currentQuestion.answer1;
                    answer_1_button.Tag = Enum.vop1;
                    answer_2_button.Content = currentQuestion.answer2;
                    answer_2_button.Tag = Enum.vop2;
                }
                else
                {
                    MessageBox.Show("Недостаточно вопросов в тесте");
                }
            }
            else
            {
                MessageBox.Show("Не удалось загрузить тест или тест отсутствует");
            }
        }

        private void CheckAnswer(Enum selectedAnswer)
        {
            if (tests[num_of_que].correct_answer == selectedAnswer)
            {
                var rand = new Random();
                var msg = variable_positive[rand.Next(0, variable_positive.Count)];
                _message.Text = msg;
                right_answers++;
            }
            else
            {
                var rand = new Random();
                var msg = variable_not[rand.Next(0, variable_not.Count)];
                _message.Text = msg;
            }

            num_of_que++;

            if (num_of_que < tests.Count)
            {
                DisplayQuestion();
            }
            else
            {
                Task.Delay(100).Wait();
                answer_1_button.IsEnabled = false;
                answer_2_button.IsEnabled = false;
                _message.Text = $"{right_answers} из {tests.Count}";
            }
        }
    }
}