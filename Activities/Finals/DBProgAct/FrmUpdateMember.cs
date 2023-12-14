using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBProgAct {

    internal delegate void UpdateOccurredDelegate();

    public partial class FrmUpdateMember : Form {

        internal event UpdateOccurredDelegate? UpdateOccurred;

        private ClubRegistrationQuery clubRegistrationQuery;
        private bool isEdited = false;

        private int Age;
        private string? FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        public FrmUpdateMember(ClubRegistrationQuery clubRegistrationQuery) {
            InitializeComponent();
            this.clubRegistrationQuery = clubRegistrationQuery;
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e) {
            clubRegistrationQuery.DisplayList();
            List<DataRow> items = ((DataTable)clubRegistrationQuery.bindingSauce.DataSource).AsEnumerable().ToList();
            foreach (DataRow item in items) {
                studentIDComboBox.Items.Add(item["StudentID"]);
            }
        }

        private void studentIDComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            string? val = studentIDComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(val))
                return;
            DataRow[] items = clubRegistrationQuery.dataTable.Select($"StudentID = {val}");
            if (items.Length == 0) return;
            DataRow item = items[0];
            if (item == null) return;
            if (!int.TryParse(item["Age"].ToString(), out int age)) return;
            lastNameTextBox.Text = item["LastName"].ToString();
            firstNameTextBox.Text = item["FirstName"].ToString();
            middleNameTextBox.Text = item["MiddleName"].ToString();
            genderComboBox.SelectedIndex = genderComboBox.Items.IndexOf(item["Gender"].ToString());
            programsComboBox.SelectedIndex = programsComboBox.Items.IndexOf(item["Program"].ToString());
            ageTextBox.Text = age.ToString();
            isEdited = false;
        }

        private void updateButton_Click(object sender, EventArgs e) {
            if (!isEdited) return;
            string? val = studentIDComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(val))
                return;
            if (!long.TryParse(val, out StudentId)) {
                MessageBox.Show(this, "Invalid Student ID", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Gender = genderComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(Gender)) {
                MessageBox.Show(this, "Invalid Gender item", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Program = programsComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(Program)) {
                MessageBox.Show(this, "Invalid Program item", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (!int.TryParse(ageTextBox.Text, out Age)) {
                MessageBox.Show(this, "Invalid Age", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            FirstName = firstNameTextBox.Text;
            MiddleName = middleNameTextBox.Text;
            LastName = lastNameTextBox.Text;

            if (!clubRegistrationQuery.UpdateStudent(StudentId, FirstName, MiddleName, LastName, Age, Gender, Program)) {
                MessageBox.Show(this, "Failed to update the student.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            isEdited = false;
            UpdateOccurred?.Invoke();
        }

        private void ObjectValueChanged(object sender, EventArgs e) {
            if (!isEdited) isEdited = true;
        }
    }
}
