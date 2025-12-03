using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAuto
{
    public class Task7
    {
        public void checkPhoneNumber(string phoneNumber)
        {

            String phone = "052-8238640";

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (phoneNumber[i] != phone[i])
                {
                    Console.WriteLine("The phone number is incorrect");
                    return;
                }
            }

            foreach (var item in phone)
            {
                Console.WriteLine(item);
            }

        }
    }
}
