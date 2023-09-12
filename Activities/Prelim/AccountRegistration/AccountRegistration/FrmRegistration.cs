namespace AccountRegistration {
    public partial class FrmRegistration : Form {
        public FrmRegistration() {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e) {
            // ComboBox checking if the user is selected on each item.
            if (ProgramComboBox.SelectedIndex == -1) {
                MessageBox.Show("Please select the program first.");
                return;
            }

# pragma warning disable CS8601 // Disable since we identified the selected index first. 
            StudentInfoClass.Program = ProgramComboBox.Items[ProgramComboBox.SelectedIndex].ToString();
# pragma warning restore CS8601

            // Simplification of parsing a long, to lessen the complexity and eliminate error when attempting to parse from string.
            if (!long.TryParse(ContactNumberTextBox.Text, out StudentInfoClass.ContactNo)) {
                MessageBox.Show("Parse failed on contact number.");
                return;
            }
            if (!long.TryParse(AgeTextBox.Text, out StudentInfoClass.Age)) {
                MessageBox.Show("Parse failed on age number.");
                return;
            }
            if (!long.TryParse(StudentNoTextBox.Text, out StudentInfoClass.StudentNo)) {
                MessageBox.Show("Parse failed on student number.");
                return;
            }

            StudentInfoClass.Address = AddressTextBox.Text;
            StudentInfoClass.FirstName = FirstNameTextBox.Text;
            StudentInfoClass.MiddleName = MiddleNameTextBox.Text;
            StudentInfoClass.LastName = LastNameTextBox.Text;

            using (FrmConfirm frm = new FrmConfirm()) {
                if (frm.ShowDialog() == DialogResult.OK) {
                    ProgramComboBox.SelectedIndex = -1;
                    ContactNumberTextBox.Clear();
                    AgeTextBox.Clear();
                    FirstNameTextBox.Clear();
                    MiddleNameTextBox.Clear();
                    LastNameTextBox.Clear();
                    StudentNoTextBox.Clear();
                    AddressTextBox.Clear();
                }
            }
        }
    }
}
