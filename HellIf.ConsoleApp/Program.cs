using System;
using HellIf.ConsoleApp.Domain;
using HellIf.ConsoleApp.StrategyPattern;

namespace HellIf.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMobile();
            Console.Write("\n");
        }

        private static Mobile SelectMobile4(string system, double battery = 0, bool on = false)
        {
            var strategyMobileFactory = new StrategyMobileFactory();

            if(system == Constants.SYSTEM1 || 
               system == Constants.SYSTEM2 || 
               system == Constants.SYSTEM3)
                return strategyMobileFactory.GetMobile(system);

            return strategyMobileFactory.GetMobile(system, battery, on);
        }
        private static void PrintMobile()
        {
            var mob1 = SelectMobile4(Constants.SYSTEM1);
            Console.Write(mob1);
            Console.Write("\n");

            var mob2 = SelectMobile4(Constants.SYSTEM2);
            Console.Write(mob2);
            Console.Write("\n");

            var mob3 = SelectMobile4(Constants.SYSTEM3);
            Console.Write(mob3);
            Console.Write("\n");

            var mob4 = SelectMobile4("Bevila", 100, true);
            Console.Write(mob4);
            Console.Write("\n");

            var mob5 = SelectMobile4("Strategy", 66, false);
            Console.Write(mob5);
            Console.Write("\n");
        }
    }
}
