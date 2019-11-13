using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program
    {
        static void Main(string[] args)
        {
           const double projectedRaises = 1.04;
            
            double employee1 = 10000; 
            double employee2 = 15000;
            double employee3 = 18000;

            employee1 = employee1 * projectedRaises;
            employee2 = employee2 * projectedRaises;
            employee3 = employee3 * projectedRaises;

            Console.WriteLine("Employee 1 salary is {0}", employee1);
            Console.WriteLine("Employee 2 salary is {0}", employee2);
            Console.WriteLine("Employee 3 salary is {0}", employee3);

        }
    }
}
