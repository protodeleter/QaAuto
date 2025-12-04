using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAuto
{
    public class Task10
    {

        public bool isPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ChkIfArrIsPrime(int[] arr)
        {

            if (arr == null || arr.Length == 0)
            {
                return false;
            }

            foreach (int num in arr)
            {
                if (!isPrime(num))
                {
                    return false;
                }
            }

            return true;
        }
        


    }
}
