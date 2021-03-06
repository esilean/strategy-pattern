using HellIf.ConsoleApp.Domain;
using HellIf.ConsoleApp.StrategyPattern.Interfaces;

namespace HellIf.ConsoleApp.StrategyPattern.Systems
{
    public class StrategySystemX1 : IStrategyMobile
    {
        public Mobile GetMobile()
        {
            return Mobile.CreateSystem1();
        }
    }

    public class StrategySystemX2 : IStrategyMobile
    {
        public Mobile GetMobile()
        {
            return Mobile.CreateSystem2();
        }
    }

    public class StrategySystemX3 : IStrategyMobile
    {
        public Mobile GetMobile()
        {
            return Mobile.CreateSystem3();
        }
    }
}