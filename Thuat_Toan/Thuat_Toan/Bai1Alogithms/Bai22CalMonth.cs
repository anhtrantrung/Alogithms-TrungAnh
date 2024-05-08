using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuat_Toan.Bai1Alogithms
{
    internal class Bai22CalMonth
    {
        /// <summary>
        /// Calculates the number of months needed to reach a target amount of money recursively.
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <param name="target"></param>
        /// <returns>The number of months needed to reach the target amount of money.</returns>
        public int CalMonthRecursive(double money, double rate, double target)
        {
            if (money >= target)
            {
                return 0;
            }
            else
            {
                double total = money + money * rate / 100;
                return 1 + CalMonthRecursive(total, rate, target);
            }
        }

        /// <summary>
        /// Calculates the number of months needed to double the initial amount of money with a given interest rate.
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <returns>The number of months needed to double the initial amount of money.</returns>
        public int CalMonth(double money, double rate)
        {
            double target = money * 2;
            return CalMonthRecursive(money, rate, target);
        }

        /// <summary>
        /// Another way to write this is to use a loop instead of using a recursion rule.
        /// </summary>
        /// <param name="money"></param>
        /// <param name="rate"></param>
        /// <returns>The number of months needed to double the initial amount of money.</returns>
        public int CalMonthNoRecursive(double money, double rate)
        {
            double target = money * 2;
            int months = 0;

            while (money < target)
            {
                money += money * rate / 100;
                months++;
            }

            return months;
        }
    }
}
