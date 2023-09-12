namespace AccountRegistration {
    public partial class FrmConfirm : Form {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelContactNo, DelStudNo;

        public FrmConfirm() {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void FrmConfirm_Load(object sender, EventArgs e) {
            AddressLabel.Text = DelAddress(StudentInfoClass.Address);
            AgeLabel.Text = DelNumAge(StudentInfoClass.Age).ToString();
            FirstNameLabel.Text = DelFirstName(StudentInfoClass.FirstName);
            MiddleNameLabel.Text = DelMiddleName(StudentInfoClass.MiddleName);
            LastNameLabel.Text = DelLastName(StudentInfoClass.LastName);
            StudentNoLabel.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            ContactNoLabel.Text = DelContactNo(StudentInfoClass.ContactNo).ToString();
            ProgramLabel.Text = DelProgram(StudentInfoClass.Program);
        }
    }
}
