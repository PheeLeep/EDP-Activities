namespace QueuingCashier
{
    public class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }

        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            return $"{CashierNumber}{x}";
        }
    }
}
