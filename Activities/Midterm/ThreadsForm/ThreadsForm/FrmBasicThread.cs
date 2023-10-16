using System.Reflection.Emit;

namespace ThreadsForm
{
    public partial class FrmBasicThread : Form
    {

        private Thread? ThreadA = null;
        private Thread? ThreadB = null;
        private Thread? MasterThread;

        private readonly object _lock = new object();
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lock (_lock)
            {
                if (MasterThread == null || !MasterThread.IsAlive)
                    MasterThread = new Thread(ThreadMasterMethod);
                
                if (MasterThread.ThreadState == ThreadState.Running) return;
                MasterThread.Start();
            }
        }

        private void ThreadMasterMethod()
        {
            Invoke(new Action(() =>
            {
                label1.Text = "- Before Starting Thread -";
                Console.WriteLine(label1.Text);
            }));

            ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A";
            ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadB.Name = "Thread A";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Invoke(new Action(() =>
            {
                label1.Text = "- End of Thread -";
                Console.WriteLine(label1.Text);
            }));
        }
    }
}