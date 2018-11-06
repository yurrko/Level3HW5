using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main( string[] args )
        {
            var N = 0;
            var F = 1;
            var enabled = true;
            while ( enabled )
            {
                Console.WriteLine( "Введите число" );
                enabled = int.TryParse(Console.ReadLine(), out N);

                var calClass = new CalculateFactorial( N, "second thread" );
                var thr1 = new Thread(calClass.CalculateFactorialInThread);
                var thr2 = new Thread(calClass.CalculateSumOfNumbersInThread);
                thr1.Start();
                thr2.Start();
            };
        }
    }
}
