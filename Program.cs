
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int iterations = 1000;
        object boxed = 0;
        int[]  notBoxed = new int[1000];
       
        // Boxing operation
        DateTime livingTime = DateTime.Now;
        for (int i = 0; i < iterations; i++)
        {
            boxed = i;
        }
        TimeSpan measuredTime =  DateTime.Now - livingTime;
        Console.WriteLine($"Boxing {iterations} times took {measuredTime.TotalMilliseconds} ms");

        // Unboxing operation
        int unboxed = 0;
        livingTime = DateTime.Now;
        for (int i = 0; i < iterations; i++)
        {
            unboxed = (int)boxed;
        }
        measuredTime = DateTime.Now - livingTime;
        Console.WriteLine($"Unboxing {iterations} times took {measuredTime.TotalMilliseconds} ms");

        //Not Boxing operation
        livingTime = DateTime.Now;
        for (int i = 0; i < iterations; i++)
        {
            notBoxed[i] = i;
        }
        measuredTime = DateTime.Now - livingTime;
        Console.WriteLine($"No Boxed {iterations} times took {measuredTime.TotalMilliseconds} ms");
    }
}