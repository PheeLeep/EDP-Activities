namespace QueuingCashierTP {
    public delegate void InvokeUpdateQueueDelegate();
    public class CashierClass {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;
        private static readonly object _lock = new object();

        // Fires an event when there are changes occurred on CashierQueue.
        public static event InvokeUpdateQueueDelegate? InvokeUpdateQueue; 

        public CashierClass() {
            x = 10000;
            CashierQueue = new Queue<string>();
        }

        public string CashierGeneratedNumber(string CashierNumber) {
            lock (_lock) {
                x++;
                return $"{CashierNumber}{x}";
            }
        }

        public static void ForceInvokeUpdate() {
            lock (_lock) {
                // Force to fire an event.
                InvokeUpdateQueue?.Invoke();
            }
        }

        public static string AcquirePeek() {
            lock (_lock) {
                // Checks if the CashierQueue is null, Count is zero, or attempting to peek was failed.
                // If one of the deficiencies were found, it will return "(queue empty)". Otherwise,
                // the value from 'res' will return.
                return CashierQueue == null || CashierQueue.Count == 0 || !CashierQueue.TryPeek(out string? res) ? "(queue empty)" : res;
            }
        }
    }
}
