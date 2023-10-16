namespace ThreadsForm
{
    internal class MyThreadClass
    {
        internal static void Thread1()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine($"Name of Thread: {thread.Name} = {i}");
                Thread.Sleep(1500);
            }
        }
    }
}
