using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class ReturnMethod
    {
        public int Number(int number)
        {
            int sum = 0;

            for (int i = 0; i <=number; i++)
            {
                sum+=i;
            }
            return sum;
            
            
        }
        public int Number1(int number1)
        {
            int sum1 = 0;
            for (int  i = 0;  i <number1;  i++)
            {
                sum1 ++;
            }
            return sum1;
        }
    }
}
