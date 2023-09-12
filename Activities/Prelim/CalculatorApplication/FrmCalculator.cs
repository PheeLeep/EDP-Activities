namespace CalculatorApplication {
    public partial class FrmCalculator : Form {
        private readonly object _lock = new object(); // Use this to prevent unusual behavior due to race condition.
        readonly CalculatorClass cal;

        double num1, num2;

        public FrmCalculator() {
            InitializeComponent();
            cal = new CalculatorClass(); // Instantiate the CalculatorClass.
        }

        private void FrmCalculator_Load(object sender, EventArgs e) {
            ClearButton_Click(sender, e); // Clear the input and answer first.
        }

        private void CalculateButton_Click(object sender, EventArgs e) {
            lock (_lock) {

                // This conversion check is a simplified version of using a try-catch and Convert.ToDouble() inside of.
                if (!double.TryParse(FirstNumTextBox.Text, out num1) || !double.TryParse(SecNumTextBox.Text, out num2)) {
                    MessageBox.Show("Parse error occurred. Please check your input.");
                    return;
                }

                // Check if the user selects the operator.
                string? operatorStr = OperatorComboBox.Items[OperatorComboBox.SelectedIndex].ToString();
                if (string.IsNullOrEmpty(operatorStr)) {
                    MessageBox.Show("Please select the operator.");
                    return;
                }

                // Output the summary of calculation and proceed on checking the operator that a user will about to use.
                SummaryLabel.Text = $"{num1} {operatorStr} {num2} = ";
                switch (operatorStr) {
                    case "+":
                        InvokeFormulaMethod(new Formula<double>(cal.GetSum));
                        break;
                    case "-":
                        InvokeFormulaMethod(new Formula<double>(cal.GetDifference));
                        break;
                    case "*":
                        InvokeFormulaMethod(new Formula<double>(cal.GetProduct));
                        break;
                    case "/":
                        if (num2 == 0) {
                            AnswerLabel.Text = "Div. zero error";
                            MessageBox.Show("Divided by zero is prohibited.");
                            return;
                        }
                        InvokeFormulaMethod(new Formula<double>(cal.GetQuotient));
                        break;
                }
            }
        }

        private void InvokeFormulaMethod(Formula<double> formula) {
            // This is a shortcut version, where it's cleaner than the
            // repetition version of the same method for the same type of Formula<>.
            cal.CalculateEvent += formula;
            AnswerLabel.Text = formula(num1, num2).ToString();
            cal.CalculateEvent -= formula;
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            lock (_lock) {
                AnswerLabel.Text = "---";
                SummaryLabel.Text = "---";
                FirstNumTextBox.Clear();
                SecNumTextBox.Clear();
                OperatorComboBox.SelectedIndex = 0;
            }
        }
    }
}