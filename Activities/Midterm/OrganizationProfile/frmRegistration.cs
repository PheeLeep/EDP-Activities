using System.Text.RegularExpressions;

namespace OrganizationProfile {
    public partial class frmRegistration : Form {
        private string _FullName = "";
        private int _Age = 0;
        private long _ContactNo = 0;
        private long _StudentNo = 0;

        public frmRegistration() {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e) {
            // Create a list containing course programs and gender, then
            // add each to their respective comboboxes.
            string[] ListOfPrograms = new string[] {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < ListOfPrograms.Length; i++)
                cbPrograms.Items.Add(ListOfPrograms[i]);

            string[] Genders = new string[] { "Male", "Female" };
            for (int i = 0; i < Genders.Length; i++)
                cbGender.Items.Add(Genders[i]);
        }

        private void btnRegister_Click(object sender, EventArgs e) {
   
            try {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text,
                                                               txtFirstName.Text,
                                                               txtMiddleInitial.Text);

                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy - MM - dd");

                new frmConfirmation().ShowDialog();
            } catch (FormatException) {
                MessageBox.Show(this, "Bad format found. Please check the informations you input.",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            } catch (ArgumentNullException) {
                MessageBox.Show(this, "Provided arguments are empty. Please check the informations you input.",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            } catch (OverflowException) {
                MessageBox.Show(this, "An overflow error occurred. Please try again.",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            } catch (IndexOutOfRangeException) {
                MessageBox.Show(this, "You selected the index outside the boundary. Please try again.",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            } finally {
                Clear();
            }
        }

        private void Clear() {
            // Clear all inputs and reset the other controls' values.
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleInitial.Clear();
            txtStudentNo.Clear();
            cbPrograms.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            txtContactNo.Clear();
            txtAge.Clear();
            datePickerBirthday.Value = DateTime.Now;
        }

        public long StudentNumber(string studNum) {
            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }

        public long ContactNo(string Contact) {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$")) {
                _ContactNo = long.Parse(Contact);
            } else {
                throw new FormatException();
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial) {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") ||
                Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") ||
                Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$")) {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            } else {
                throw new FormatException();
            }

            return _FullName;
        }

        public int Age(string age) {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$")) {
                _Age = Int32.Parse(age);
            } else {
                throw new FormatException();
            }

            return _Age;
        }
    }
}