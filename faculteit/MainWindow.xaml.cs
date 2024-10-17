using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace faculteit
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Clear();
            resultTextBox.Clear();
            numberTextBox.Focus();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(numberTextBox.Text, out int number);
            int answer = number;
           
            if (number == 0)
            {
                resultTextBox.Text = 1.ToString();
            } else
            {
                for (int i = number; i >= 1; i--)
                {
                    answer *= i;
                }
                resultTextBox.Text = answer.ToString();
            }
        }
    }
}