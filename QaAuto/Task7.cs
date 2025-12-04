using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAuto
{
    public class Task7
    {
        public bool checkPhoneNumber(string phoneNumber)
        {

            // check if first dig is 0 and second is 5
            if ((int) phoneNumber[0] != 48 || (int)phoneNumber[1] != 53 )
            {
                return false;
            }


            // check if third dig is bigger than 8
            if ((int)phoneNumber[2] > 56)
            {
                return false;
            }

            // check if fourth dig is '-'
            if ( (int) phoneNumber[3] != 45)
            {
                return false;
            }
            return true;
        }
    }
}
