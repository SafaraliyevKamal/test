using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // arr'de verilen ededlerin -,+ ve beraber olan ededlerin sayi
            //arrey arr = new arrey();
            //arr.ArrNumber();
            #endregion
            //ReturnMethod say = new ReturnMethod();
            //Console.WriteLine(say.Number(23));
            //Console.WriteLine(say.Number1(23));
            person yas = new person();
            Console.WriteLine(yas.Fulname("Kamal", "Safaraliyev"));
            Console.WriteLine(yas.Person(1999));

        }



    }
}
