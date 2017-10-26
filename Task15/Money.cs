using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
    public struct Money
    {
        public int grn, cop;
        public bool isNegative;

        public Money(int grn, int cop)
        {
            this.cop = cop;
            this.grn = grn;
            isNegative = false;
        }

        public static Money Addition(Money money1, Money money2)
        {
            int totalCop = money1.cop + money2.cop;
            int totalGrn = money1.grn + money2.grn;

            if (totalCop / 100  == 1)
            {
                totalCop %= 100;
                totalGrn++;
            }

            return new Money(totalGrn, totalCop);
        }

        public static Money Subtraction(Money money1, Money money2)
        {
            Money res = new Money();
            res.cop = money1.cop - money2.cop;
            res.grn = money1.grn - money2.grn;
            

            if (res.grn <= 0)
            {
                if(res.cop < 0)
                    res.cop *= -1;
                
                res.isNegative = true;
                
                if (res.cop == 0 && res.grn == 0)
                    res.isNegative = false;

            }

            return res;
        }

        public string ToString()
        {
            if (isNegative)
            {
                return $"-{this.grn}grn {this.cop}cop";
            }
            return $"{this.grn}grn {this.cop}cop";
        }
    }
}
