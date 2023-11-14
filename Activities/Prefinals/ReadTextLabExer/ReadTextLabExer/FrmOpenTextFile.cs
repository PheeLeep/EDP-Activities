namespace ReadTextLabExer
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = "Browse Text Files";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

                string path = openFileDialog1.FileName;
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string? _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvShowText.Items.Add(_getText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to open a file.\n\nReason: {ex.Message}", "", MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
            }
        }
    }
}
