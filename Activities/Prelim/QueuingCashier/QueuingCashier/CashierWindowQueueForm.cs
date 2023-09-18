using System.Collections;

namespace QueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        private readonly object _lock = new object();
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            lock (_lock)
            {
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }

        private void DisplayCashierQueue(IEnumerable CashierList)
        {
            ListCashierQueue.Items.Clear();
            foreach (var c in CashierList)
            {
                if (c is null) continue;
                string? str = c as string;
                if (string.IsNullOrEmpty(str)) continue;
                ListCashierQueue.Items.Add(str);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                RefreshButton_Click(sender, e);
            }
            catch
            {
                // Ignore.
            }
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            lock (_lock)
            {
                if (CashierClass.CashierQueue.Count > 0)
                    CashierClass.CashierQueue.Dequeue();
            }
        }
    }
}
