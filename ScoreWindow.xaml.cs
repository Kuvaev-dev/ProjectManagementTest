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
    /// Логика взаимодействия для ScoreWindow.xaml
    /// </summary>
    public partial class ScoreWindow : Window
    {
        public ScoreWindow()
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
            MainWindow mainWindow = new();
            mainWindow.ShowDialog();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow mainWindow = new();
            mainWindow.ShowDialog();
        }
    }
}
