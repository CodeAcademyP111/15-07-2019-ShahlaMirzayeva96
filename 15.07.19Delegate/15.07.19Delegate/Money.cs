using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15._07._19Delegate
{
     class Money
    {
        public event Action<int,int> GetMoneyEvent;
        public int Pul { get; private set; }
         public Money(int n)
        {
            Pul = n;
        }

        public  void GetMoney(int n)
        {
            if (n < Pul)
            {
                Console.WriteLine($"{n} Manat");
            }
            else
            {
                GetMoneyEvent.Invoke(Pul,n);
            }
        }
    }
}
