namespace TextFileLabExer
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (frmFileName fileName = new frmFileName())
            {
                if (fileName.ShowDialog() != DialogResult.OK) return;

                try
                {
                    string getInput = txtInput.Text;
                    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, frmFileName.SetFileName)))
                    {
                        writer.WriteLine(getInput);
                        Console.WriteLine(getInput);
                    }
                    MessageBox.Show(this, "Saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, $"Failed to save a file.\n\nReason: {ex.Message}",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
