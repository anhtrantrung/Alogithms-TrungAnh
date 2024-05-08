using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai21CalSalary
    {
        /// <summary>
        /// Calculates the salary recursively based on an initial salary and the number of iterations.
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="n"></param>
        /// <returns>The calculated salary after applying the increase recursively.</returns>
        public double CalculateSalaryRecursive(double salary, int n)
        {
            if (n == 1)
            {
                return salary;
            }
            else
            {
                return CalculateSalaryRecursive(salary * 1.1, n - 1);
            }
        }

        /// <summary>
        /// Another way to write this is to use a loop instead of using a recursion rule.
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="n"></param>
        /// <returns>The calculated salary after applying the increase iteratively.</returns>
        public double CalculateSalary(double salary, int n)
        {
            for (int i = 1; i < n; i++)
            {
                salary *= 1.1;
            }
            return salary;
        }
    }
}
