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

namespace Lab12_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceReference1.Service1Client sluzba = new ServiceReference1.Service1Client();
        private string op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Operator.Text)
            {
                case "+":
                    op = "plus";
                    break;
                case "-":
                    op = "minus";
                    break;
                case "*":
                    op = "mult";
                    break;
                case "/":
                    op = "divide";
                    break;
                default:
                    break;
            }
            decimal response = sluzba.Spocti(Convert.ToDecimal(Operand1.Text), Convert.ToDecimal(Operand2.Text), op);
            Result.Text = Convert.ToString(response);
        }
    }
}
