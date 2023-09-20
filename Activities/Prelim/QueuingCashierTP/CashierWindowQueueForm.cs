using System.Collections;

namespace QueuingCashierTP {
    public partial class CashierWindowQueueForm : Form {
        private readonly object _lock = new object();
        public CashierWindowQueueForm() {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            lock (_lock) {
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }

        private void DisplayCashierQueue(IEnumerable CashierList) {
            lock (_lock) {
                ListCashierQueue.Items.Clear();
                foreach (var c in CashierList) {
                    if (c is null) continue;
                    string? str = c as string;
                    if (string.IsNullOrEmpty(str)) continue;
                    ListCashierQueue.Items.Add(str);
                }
            }
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e) {
            // Using an event will update the list in an instant, than Timer.
            CashierClass.InvokeUpdateQueue += CashierClass_InvokeUpdateQueue;
        }

        private void CashierClass_InvokeUpdateQueue() {
            RefreshButton_Click(RefreshButton, EventArgs.Empty);
        }

        private void NextButton_Click(object sender, EventArgs e) {
            lock (_lock) {
                if (CashierClass.CashierQueue.Count > 0) {
                    CashierClass.CashierQueue.Dequeue();
                    CashierClass.ForceInvokeUpdate();
                }
            }
        }
    }
}
