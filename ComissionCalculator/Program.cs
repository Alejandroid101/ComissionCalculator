using System;

namespace ComissionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comission Calculator.");
            Console.WriteLine("Input System Size:");
            string systemSize = Console.ReadLine();
            decimal numSys = Decimal.Parse(systemSize);
            Console.WriteLine("Input Price/kW:");
            string ppkw = Console.ReadLine();
            decimal numPpkw = Decimal.Parse(ppkw);
            Console.WriteLine("Input Comission Rate:");
            string comRate = Console.ReadLine();
            decimal numComish = Decimal.Parse(comRate);
            Console.WriteLine("Input APR:");
            string apr = Console.ReadLine();
            decimal numApr = Decimal.Parse(apr);
            Console.WriteLine("Input techo:");
            string techo = Console.ReadLine();
            int numTecho = int.Parse(techo);
            Console.WriteLine("Input filter:");
            string filter = Console.ReadLine();
            int numFilter = int.Parse(filter);
            Console.WriteLine("Input insulation:");
            string insul = Console.ReadLine();
            int numInsul = int.Parse(insul);
            int adders = numTecho + numFilter + numInsul;


            Console.WriteLine("System size is " + systemSize);
            Console.WriteLine("price per kw is " + ppkw);
            Console.WriteLine("paid at a comission rate of " + comRate);
            Console.WriteLine("the interest rate is " + apr);
            Console.WriteLine("the total adders is: " + adders);



        }

    }
}
