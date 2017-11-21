using System;
using System.Collections.Generic;
using System.Text;

namespace Task15
{
    public struct Money
    {
        public int grn, cop;
        public int totalCop;

        public Money(int grn, int cop)
        {
            this.cop = cop;
            this.grn = grn;
            totalCop = grn * 100 + cop;
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

            res.totalCop = money1.totalCop - money2.totalCop;

            res.grn = res.totalCop / 100;
            res.cop = res.totalCop % 100;

            return res;
        }

        public string ToString()
        {
            if (this.totalCop < 0)
            {
                return $"-{this.grn}grn {this.cop * (-1)}cop";
            }
            return $"{this.grn}grn {this.cop}cop";
        }
    }
}
