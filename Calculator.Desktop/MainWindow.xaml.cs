using Calculator.Domain;
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

namespace Calculator.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] inputs;
        private double output;
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtInputs.Text == "")
            {
                MessageBox.Show("Please fill in the input first");
                return;
            }

            try
            {

                this.inputs = this.txtInputs.Text.Split(',').Select(x => int.Parse(x)).ToArray();
                this.txtOutput.Text = CalculatorLib.Add(this.inputs).ToString();
                var result = cbOperation.Text switch
                {
                    "Add" => CalculatorLib.Add(this.inputs).ToString(),
                    "Substract" => CalculatorLib.Substract(this.inputs).ToString(),
                    "Divide" => CalculatorLib.Divide(this.txtInputs.Text.Split(',').Select(x => Double.Parse(x)).ToArray()).ToString(),
                    "Multiply" => CalculatorLib.Multiply(this.inputs).ToString(),
                    "SplitEq" => string.Join(',', CalculatorLib.SplitEq(this.inputs[0], this.inputs[1])),
                    "SplitNum" => CalculatorLib.SplitNum(this.inputs).ToString(),
                    _ => "Please select an operation"

                };

                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
