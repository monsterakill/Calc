using System.Windows;

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
     public partial class MainWindow : Window
    {
        CalcViewModel cvm;
        public MainWindow()
        {          
           
            InitializeComponent();           
            cvm = (CalcViewModel)base.DataContext;
        }
        void SetViewModel(string Content)
        {
            cvm.updateNumber = double.Parse(Content.ToString());
        }
        private void num7_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num7.Content.ToString());
        }

        private void num8_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num8.Content.ToString());
        }

        private void num9_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num9.Content.ToString());
        }

        private void num4_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num4.Content.ToString());
        }

        private void num5_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num5.Content.ToString());
        }

        private void num6_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num6.Content.ToString());
        }

        private void num1_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num1.Content.ToString());
        }

        private void num2_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num2.Content.ToString());
        }

        private void num3_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num3.Content.ToString());
        }

        private void num0_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(num0.Content.ToString());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            cvm.add();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            cvm.clearAll();
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            cvm.equal();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            cvm.Multiply();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            cvm.subtract();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            cvm.Divide();
        }
    }
}
