namespace DBProgAct {
    public partial class FrmClubRegistration : Form {

        private readonly ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string? FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;


        public FrmClubRegistration() {
            InitializeComponent();
            clubRegistrationQuery = new ClubRegistrationQuery();
        }

        private void Form1_Load(object sender, EventArgs e) {
            genderComboBox.SelectedIndex = 0;
            programsComboBox.SelectedIndex = 0;
        }

        private void RefreshListOfClubMembers() {
            clubRegistrationQuery.DisplayList();
            clubMembersDGV.DataSource = clubRegistrationQuery.bindingSauce;
        }

        private int RegistrationID() {
            count++;
            return count;
        }

        private void RegisterButton_Click(object sender, EventArgs e) {
            if (!long.TryParse(studIDTextBox.Text, out StudentId)) {
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
            ID = RegistrationID();
            if (!clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program)) {
                MessageBox.Show(this, "Failed to register a student.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            RefreshListOfClubMembers();
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            RefreshListOfClubMembers();
        }

        private void updateButton_Click(object sender, EventArgs e) {
            using (FrmUpdateMember frm = new FrmUpdateMember(clubRegistrationQuery)) {
                frm.UpdateOccurred += RefreshListOfClubMembers;
                frm.ShowDialog(this);
                frm.UpdateOccurred -= RefreshListOfClubMembers;
            }
        }
    }
}
