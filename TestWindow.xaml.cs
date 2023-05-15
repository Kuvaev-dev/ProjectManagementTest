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

namespace ManagementQuizKuvaiev
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        private List<Question> questions;
        private int questionIndex = 0;
        private int score = 0;

        public TestWindow()
        {
            InitializeComponent();
        }

        private void MinimizeWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void WindowInWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
        }

        private void MaximizeWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void CloseWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            ScoreWindow scoreWindow = new();
            scoreWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            questions = new()
            {
                new("Q1","A1","B1","C1","D1",1),
                new("Q2","A2","B2","C2","D2",1)
            };

            QuestionTB.Text = questions[questionIndex].QuestionText;
            AnswerARB.Content = questions[questionIndex].AnswerA;
            AnswerBRB.Content = questions[questionIndex].AnswerB;
            AnswerCRB.Content = questions[questionIndex].AnswerC;
            AnswerDRB.Content = questions[questionIndex].AnswerD;
        }

        private void PreviousQuestionBtn_Click(object sender, RoutedEventArgs e)
        {
            if (questionIndex == 0)
            {
                QuestionTB.Text = questions[0].QuestionText;
                AnswerARB.Content = questions[0].AnswerA;
                AnswerBRB.Content = questions[0].AnswerB;
                AnswerCRB.Content = questions[0].AnswerC;
                AnswerDRB.Content = questions[0].AnswerD;
            }
            else questionIndex--;
        }

        private void CompleteTestBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            ScoreWindow scoreWindow = new();
            scoreWindow.ShowDialog();
        }

        private void NextQuestionBtn_Click(object sender, RoutedEventArgs e)
        {
            if (questionIndex == questions.Count - 1)
            {
                QuestionTB.Text = questions[questions.Count].QuestionText;
                AnswerARB.Content = questions[questions.Count].AnswerA;
                AnswerBRB.Content = questions[questions.Count].AnswerB;
                AnswerCRB.Content = questions[questions.Count].AnswerC;
                AnswerDRB.Content = questions[questions.Count].AnswerD;
            }
            else
            {
                foreach (var question in questions)
                {
                    QuestionTB.Text = question.QuestionText;
                    AnswerARB.Content = question.AnswerA;
                    AnswerBRB.Content = question.AnswerB;
                    AnswerCRB.Content = question.AnswerC;
                    AnswerDRB.Content = question.AnswerD;

                    if (AnswerARB.TabIndex == question.CorrectAnswerIndex 
                        || AnswerBRB.TabIndex == question.CorrectAnswerIndex
                        || AnswerCRB.TabIndex == question.CorrectAnswerIndex
                        || AnswerDRB.TabIndex == question.CorrectAnswerIndex)
                    {
                        score++;
                        questionIndex++;
                    }
                }
            }
        }
    }
}
