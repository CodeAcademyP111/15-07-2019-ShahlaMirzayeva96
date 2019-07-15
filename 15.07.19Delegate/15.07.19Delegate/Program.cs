using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15._07._19Delegate
{
    class Program
    {
        //public delegate int DelegateMeth(int m);
        static void Main(string[] args)
        {

            //DelegateMeth deleMethod= SimpleNumber;
            //deleMethod += MinusNumber;
            //deleMethod += DoubleSingleNum;
            //deleMethod(18);

            //Func<int,int> delegateMethod = SimpleNumber;
            //delegateMethod += MinusNumber;
            //delegateMethod += DoubleSingleNum;
            //delegateMethod(6);

            Money money = new Money(60);
            money.GetMoneyEvent += delegate (int x,int y)
              {
                  Console.WriteLine($"Kifayet qeder balansiniz yoxdur");
                  
              };
               money.GetMoney(70);
           
        }
        
        static int SimpleNumber(int n)
        {

            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
               

            }
            if (count > 2)
            {
                Console.WriteLine($"{ n } Murekkeb ededdir");

            }
            else
            {
                
                Console.WriteLine($"{ n } Sade ededdir");

            }
            return n;
           
        }

        static int MinusNumber(int m)
        {
            if (m > 0)
            {
                Console.WriteLine($"{m} Musbet ededdir");
            }
            else
            {
                Console.WriteLine($"{m} Menfi ededdir");
            }
            return m;
        }

        static int DoubleSingleNum(int x)
        {
            if (x % 2 == 1)
            {
                Console.WriteLine($"{x} Tek ededdir");
            }else if (x % 2 == 0)
            {

                Console.WriteLine($"{x} Cut ededdir");
            }
            return x;
        }
    }
}
