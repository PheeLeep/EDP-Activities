namespace QueuingCashierTP {
    public partial class QueuingForm : Form {
        private CashierClass cashier;
        private CashierWindowQueueForm queueForm;
        private NowServingForm nServeForm;

        public QueuingForm() {
            InitializeComponent();
            cashier = new CashierClass();
            queueForm = new CashierWindowQueueForm();
            nServeForm = new NowServingForm();
        }

        private void CashierButton_Click(object sender, EventArgs e) {
            QueueLabel.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = QueueLabel.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            CashierClass.ForceInvokeUpdate();
        }

        private void QueuingForm_Load(object sender, EventArgs e) {
            while (!IsHandleCreated)
                Thread.Sleep(10);
            queueForm.Show();
            nServeForm.Show();
        }

        private void QueuingForm_FormClosing(object sender, FormClosingEventArgs e) {
            queueForm.Close();
            nServeForm.Close();
        }
    }
}