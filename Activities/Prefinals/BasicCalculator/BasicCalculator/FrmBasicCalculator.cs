using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            opComboBox.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                if (!float.TryParse(txtFirstNum.Text, out float firstNum))
                    throw new InvalidOperationException("First number is invalid.");
                if (!float.TryParse(txtSecNum.Text, out float secNum))
                    throw new InvalidOperationException("Second number is invalid.");

                lblAnswer.Text = opComboBox.Text switch
                {
                    "+" => BasicComputation.Addition(firstNum, secNum).ToString(),
                    "-" => BasicComputation.Subtraction(firstNum, secNum).ToString(),
                    "*" => BasicComputation.Multiplication(firstNum, secNum).ToString(),
                    "/" => BasicComputation.Division(firstNum, secNum).ToString(),
                    _ => throw new InvalidOperationException("No operator that has been selected.")
                };
            }
            catch (Exception ex)
            {
                lblAnswer.Text = "Err";
                MessageBox.Show(this, $"Failed to compute.\n\nCause: {ex.Message}", ""
                                , MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
