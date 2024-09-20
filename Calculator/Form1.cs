using System.CodeDom.Compiler;
using System.Configuration;
using System.Windows.Forms;
using Calculator.Infrastructure;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public enum Operations
        {
            Add,
            Substract,
            Multiply,
            Divide,
            None
        }
        Operations operation = Operations.None;
        bool finished = false;
        double number1 = 0;
        double number2 = 0;

        private readonly IMathService _mathService;
        public Form1(IMathService mathService)
        {
            InitializeComponent();
            _mathService = mathService;
        }

        private void BT_plus_Click(object sender, EventArgs e)
        {
            if (finished) return;
            if (!double.TryParse(TB_Field.Text, out number1))
            {
                MessageBox.Show("Error: Not number");
                return;
            }
            operation = Operations.Add;
            TB_Field.Focus();
            TB_Field.SelectAll();
        }

        private void BT_Minus_Click(object sender, EventArgs e)
        {
            if (finished) return;
            if (!double.TryParse(TB_Field.Text, out number1))
            {
                MessageBox.Show("Error: Not number");
                return;
            }
            operation = Operations.Substract;
            TB_Field.Focus();
            TB_Field.SelectAll();
        }

        private void BT_Multi_Click(object sender, EventArgs e)
        {
            if (finished) return;
            if (!double.TryParse(TB_Field.Text, out number1))
            {
                MessageBox.Show("Error: Not number");
                return;
            }
            operation = Operations.Multiply;
            TB_Field.Focus();
            TB_Field.SelectAll();
        }

        private void BT_Division_Click(object sender, EventArgs e)
        {
            if (finished) return;
            if (!double.TryParse(TB_Field.Text, out number1))
            {
                MessageBox.Show("Error: Not number");
                return;
            }
            operation = Operations.Divide;
            TB_Field.Focus();
            TB_Field.SelectAll();
        }

        private void BT_Result_Click(object sender, EventArgs e)
        {
            if (finished) return;
            try
            {
                switch (operation)
                {
                    case Operations.Add:
                        DoAddOperation();
                        break;
                    case Operations.Substract:
                        DoSubstractOperation();
                        break;
                    case Operations.Multiply:
                        DoMultiplyOperation();
                        break;
                    case Operations.Divide:
                        DoDivideOperation();
                        break;
                    default:
                        MessageBox.Show("No operation");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                FocusAndSelect();
            }

        }

        private void DoDivideOperation()
        {
            if (!double.TryParse(TB_Field.Text, out number2))
            {
                MessageBox.Show("Error: Not number");
                return;
            }
            TB_Result.Text = "" + _mathService.DivideNumbers(number1, number2);
            finished = true;
        }

        private void DoSubstractOperation()
        {
            if (!double.TryParse(TB_Field.Text, out number2))
            {
                MessageBox.Show("Error: Not number");
                return;
            }
            TB_Result.Text = "" + _mathService.SubstractNumbers(number1, number2);
            finished = true;
        }

        private void DoMultiplyOperation()
        {
            if (!double.TryParse(TB_Field.Text, out number2))
            {
                MessageBox.Show("Error: Not number");
                return;
            }
            TB_Result.Text = "" + _mathService.MultiplyNumbers(number1, number2);
            finished = true;
        }

        private void DoAddOperation()
        {
            if (!double.TryParse(TB_Field.Text, out number2))
            {
                MessageBox.Show("Error: Not number");
                return;
            }
            TB_Result.Text = "" + _mathService.AddNumbers(number1, number2);
            finished = true;
        }

        // DRY Princip dont repeat urself
        private void FocusAndSelect()
        {
            TB_Field.Focus();
            TB_Field.SelectAll();
        }
        private void BT_Clear_Click(object sender, EventArgs e)
        {
            TB_Field.Text = String.Empty;
            TB_Result.Text = String.Empty;
            finished = false;
            number1 = 0;
            number2 = 0;
            operation = Operations.None;
        }
    }
}
