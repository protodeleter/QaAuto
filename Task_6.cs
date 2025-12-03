using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix
{
    public class Task_6
    {
        
        public bool perfectNumber(int numb)
        {

            int res = 0;
            int sum = 0;
            int temp = numb;

            while (temp > 0)
            {
                res = temp % 10;
                temp = temp / 10;

                sum = sum + res;
            }


            if (numb % sum == 0)
            {
                return true;
            }

            return false;
        }

    }
}
