using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4
{
    public class Delegate
    {
        private List<double> _list = new List<double>();
        public event Func<double, double, double> DoSum;

        public int FinallSum
        {
            get
            {
                var sumResult = 0;
                foreach (int item in _list)
                {
                    sumResult += item;
                }

                return sumResult;
            }
        }

        public void Subscribe()
        {
            DoSum += Sum;
            DoSum += Sum;
        }

        public void CountSum()
        {
            TryCatchMethod(() => DoSum(2, 2));
        }

        public static void TryCatchMethod(Action action)
        {
            try
            {
                action();
            }
            catch (Exception massage)
            {
                Console.WriteLine(massage);
            }
        }

        private double Sum(double x, double y)
        {
            var result = x + y;
            _list.Add(result);
            return result;
        }
    }
}
