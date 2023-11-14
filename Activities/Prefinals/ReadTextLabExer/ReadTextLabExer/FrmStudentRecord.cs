namespace ReadTextLabExer
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = "Browse Text Files";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

                lvItems.Items.Clear();
                string path = openFileDialog1.FileName;
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string? _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvItems.Items.Add(_getText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to open a file.\n\nReason: {ex.Message}", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lvItems.Items.Count == 0)
            {
                MessageBox.Show(this, "No records loaded.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(this, "Successfully Uploaded!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvItems.Items.Clear();
        }
    }
}
