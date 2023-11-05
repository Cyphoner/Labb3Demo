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

namespace Labb3Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartQuiz_click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
        }

        public class Question
        {
            public string Statement { get; }
            public string[] Answers { get; }
            public int CorrectAnswer { get; }
        }

        public class Quiz
        {
            private IEnumerable<Question> _questions;
            private string _title = string.Empty;
            public IEnumerable<Question> Questions => _questions;
            public string Title => _title;

            public Quiz()
            {
                _questions = new List<Question>();
            }

            public Question GetRandomQuestion()
            {
                throw new NotImplementedException("A random Question needs to be returned here!");
            }

            public void AddQuestion(string statement, int correctAnswer, params string[] answers)
            {
                throw new NotImplementedException("Question need to be instantiated and added to list of questions here!");
            }

            public void RemoveQuestion(int index)
            {
                throw new NotImplementedException("Question at requested index need to be removed here!");
            }
        }

        private void StartQuizButton_Click(object sender, RoutedEventArgs e)
        {
            QuizView CategoryView = new QuizView();
            CategoryView.Show();
        }

        private void CategoryButton_Click(object sender, RoutedEventArgs e)
        {
            QuizView CategoryView = new QuizView();
            CategoryView.Show();
        }

        private void CustomQuizButton_Click(object sender, RoutedEventArgs e)
        {
            CustomQuizWindow QuizEditor = new CustomQuizWindow();
            QuizEditor.Show();
        }

        private void ExitQuizButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit The Quiz?", "Exit Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
