using System;

namespace Module3HW4
{
    public class Program
    {
        public static void Main()
        {
            var myDelegate = new Delegate();
            myDelegate.Subscribe();
            myDelegate.CountSum();
            Console.WriteLine(myDelegate.FinallSum);
        }
    }
}
