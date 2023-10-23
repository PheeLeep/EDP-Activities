namespace TrackThread
{
    public partial class frmTrackThread : Form
    {
        private Thread? threadA;
        private Thread? threadB;
        private Thread? threadC;
        private Thread? threadD;

        private bool isStarted = false;
        private readonly object _lock = new object();

        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lock (_lock)
            {
                if (isStarted) return;
                isStarted = true;

                new Thread(() =>
                {
                    
                    threadA = new Thread(MyThreadClass.Thread1) {
                        Priority = ThreadPriority.Highest,
                        Name = "Thread A Process"
                    };
                    threadB = new Thread(MyThreadClass.Thread2)
                    {
                        Priority = ThreadPriority.Normal,
                        Name = "Thread B Process"
                    };
                    threadC = new Thread(MyThreadClass.Thread1)
                    {
                        Priority = ThreadPriority.AboveNormal,
                        Name = "Thread C Process"
                    };
                    threadD = new Thread(MyThreadClass.Thread2)
                    {
                        Priority = ThreadPriority.BelowNormal,
                        Name = "Thread D Process"
                    };

                    WriteOutput("-Thread Starts-");
                    threadA.Start();
                    threadB.Start();
                    threadC.Start();
                    threadD.Start();

                    threadA.Join();
                    threadB.Join();
                    threadC.Join();
                    threadD.Join();

                    WriteOutput("-End of Thread-");
                    isStarted = false;
                }).Start();
            }
        }

        private void WriteOutput(string output)
        {
            try
            {
                Invoke(new Action(() => label1.Text = output)) ;
            } catch (Exception ex)
            {
                // Might be an error while invoking.
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine(output);
        }
    }
}