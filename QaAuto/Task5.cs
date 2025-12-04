using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAuto
{
    public class Task5
    {
        public bool brothers(int a, int b)
        {

            int firstDigit = 0;
            int secondDigit = 0;

            int thirdDigit = 0;
            int fourDigit = 0;

            for (int i = 0; i < a || i < b; i++)
            {
                if (a % 10 == b % 10)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
