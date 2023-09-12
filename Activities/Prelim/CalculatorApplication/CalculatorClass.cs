namespace CalculatorApplication {

    public delegate T Formula<T>(T arg1, T arg2);
    internal class CalculatorClass {

        private Formula<double>? info;

        public event Formula<double> CalculateEvent {

            add {
                if (value is null) {
                    Console.WriteLine("Value provided is null.");
                    return;
                }
                info += value;
                Console.WriteLine($"Value {value.Method.Name} was added to the delegate.");
            }
            remove {
                if (value is null) {
                    Console.WriteLine("Value provided is null.");
                    return;
                }
                info -= value;
                Console.WriteLine($"Value {value.Method.Name} removed from the delegate.");
            }
        }

        public double GetSum(double arg1, double arg2) {
            return arg1 + arg2;
        }
        public double GetDifference(double arg1, double arg2) {
            return arg1 - arg2;
        }
        public double GetProduct(double arg1, double arg2) {
            return arg1 * arg2;
        }
        public double GetQuotient(double arg1, double arg2) {
            return arg1 / arg2;
        }
    }
}
