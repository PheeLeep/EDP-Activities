namespace QueuingCashierTP {
    public partial class NowServingForm : Form {
        public NowServingForm() {
            InitializeComponent();
        }

        private void NowServingForm_Load(object sender, EventArgs e) {
            while (!IsHandleCreated)
                Thread.Sleep(10);
            CashierClass.InvokeUpdateQueue += CashierClass_InvokeUpdateQueue;
            CashierClass_InvokeUpdateQueue();
        }

        private void CashierClass_InvokeUpdateQueue() {
            QueueLabel.Text = CashierClass.AcquirePeek();
        }
    }
}
