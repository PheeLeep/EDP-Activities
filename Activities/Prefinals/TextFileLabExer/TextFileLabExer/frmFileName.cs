namespace TextFileLabExer
{
    public partial class frmFileName : Form
    {

        internal static string SetFileName = string.Empty;
        public frmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text;
            if (!SetFileName.Contains(".txt"))
                SetFileName += ".txt";

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
