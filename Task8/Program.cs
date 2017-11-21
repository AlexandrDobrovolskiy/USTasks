using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Task8;

namespace Task_8
{
    
    class Program
    {
        static void Main(string[] args)
        {

            BallInTheBox myBallInTheBox = new BallInTheBox(1,1,20,15,2);

            while (true)
            {
                myBallInTheBox.Move();
                Console.WriteLine(myBallInTheBox.ToString());
                Thread.Sleep(500);
            }
           
        }
    }
}