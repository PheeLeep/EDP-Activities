using System.Threading;

namespace TrackThread
{
    internal static class MyThreadClass
    {

        internal static void Thread1()
        {
            Thread thread = Thread.CurrentThread;
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Console.WriteLine($"Name of Thread: {thread.Name} = {loopCount}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"Thread '{thread.Name}' has exited.");
        }

        internal static void Thread2()
        {
            Thread thread = Thread.CurrentThread;
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Console.WriteLine($"Name of Thread: {thread.Name} = {loopCount}");
                Thread.Sleep(1500);
            }
            Console.WriteLine($"Thread '{thread.Name}' has exited.");
        }
    }
}
