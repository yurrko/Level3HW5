using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class CalculateFactorial
    {
        private int _n;
        private double _f;
        private double _sum;
        private string _threadName;

        public CalculateFactorial( int n, string threadName)
        {
            _n = n;
            _threadName = threadName;
            _f = 1;
            _sum = 0;
        }

        public void CalculateFactorialInThread()
        {
            //Console.WriteLine(_threadName);
            for ( var i = 1; i <= _n; i++ )
            {
                _f *= i;
            }

            Console.WriteLine($"Factorial = {_f}");
        }

        public void CalculateSumOfNumbersInThread()
        {
            //Console.WriteLine(_threadName);
            for (int i = 0; i < _n; i++)
            {
                _sum += i;
            }
            Console.WriteLine( $"Sum = {_sum}" );
        }
    }
}
