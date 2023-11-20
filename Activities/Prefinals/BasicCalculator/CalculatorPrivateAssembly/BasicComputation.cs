namespace CalculatorPrivateAssembly
{
    public class BasicComputation
	{
        public static float Addition(float firstNum, float secNum)
        {
            return firstNum + secNum;
        }

        public static float Subtraction(float firstNum, float secNum)
        {
            return firstNum - secNum;
        }

        public static float Multiplication(float firstNum, float secNum)
        {
            return firstNum * secNum;
        }

        public static float Division(float firstNum, float secNum)
        {
            return secNum != 0 ? firstNum / secNum : throw new DivideByZeroException();
        }
    }
}