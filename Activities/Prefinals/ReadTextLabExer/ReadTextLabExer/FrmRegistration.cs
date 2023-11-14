namespace ReadTextLabExer
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) ||
                    string.IsNullOrEmpty(txtMI.Text))
                    throw new InvalidOperationException("Values are empty.");

                if (!ulong.TryParse(txtStudNo.Text, out _)) throw new FormatException("Invalid student number.");
                if (!ushort.TryParse(txtAge.Text, out _)) throw new FormatException("Invalid age number.");
                if (!ulong.TryParse(txtContactNo.Text, out _)) throw new FormatException("Invalid contact number.");

                string[] result =
                {
                    $"Student No.: {txtStudNo.Text}",
                    $"Full Name: {txtLastName.Text}, {txtFirstName.Text} {txtMI.Text}",
                    $"Program: {cbPrograms.SelectedItem}",
                    $"Gender: {cbGender.SelectedItem}",
                    $"Age: {txtAge.Text}",
                    $"Birthday: {dtpBirthday.Value:yyyy-mm-dd}",
                    $"Contact No.: {txtContactNo.Text}"
                };

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, txtStudNo.Text + ".txt")))
                {
                    foreach (string line in result)
                    {
                        writer.WriteLine(line);
                        Console.WriteLine(line);
                    }
                }
                MessageBox.Show(this, "Saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to register\n\nCause: {ex.Message}",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            cbPrograms.SelectedIndex = 0;
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            new FrmStudentRecord().ShowDialog(this);
        }
    }
}
