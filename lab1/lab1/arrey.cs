using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class arrey
    {
       public int[] arr = { 1, 7, 3, 8, 6, -3, -9, 0, 0, 54, -2, 5, -8, 9, 5, 2 };
        

        public  void ArrNumber()
        {
            int sum = 0;
            int sump1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    sum++;
                }
                else if (arr[i] > 0)
                {
                    sump1++;
                }
                else 
                {
                    sum2++;
                }
                
                
            }

            Console.WriteLine($"{sum} {sum2} {sump1}");
        }// arr'de verilen ededlerin -,+ ve beraber olan ededlerin sayi


        
    }
}
