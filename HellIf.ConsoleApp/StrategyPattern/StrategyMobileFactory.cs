using System.Collections.Generic;
using HellIf.ConsoleApp.Domain;
using HellIf.ConsoleApp.StrategyPattern.Interfaces;
using HellIf.ConsoleApp.StrategyPattern.Systems;

namespace HellIf.ConsoleApp.StrategyPattern
{
    public class StrategyMobileFactory
    {
        private readonly IDictionary<string, IStrategyMobile> _map;

        public StrategyMobileFactory()
        {
            _map = new Dictionary<string, IStrategyMobile>();
            Initialize();
        }

        private void Initialize()
        {
            _map.Add(Constants.SYSTEM1, new StrategySystemX1());
            _map.Add(Constants.SYSTEM2, new StrategySystemX2());
            _map.Add(Constants.SYSTEM3, new StrategySystemX3());
        }

        public Mobile GetMobile(string system, double battery = 0, bool on = false)
        {
            if(_map.ContainsKey(system))
                return _map[system].GetMobile();

            return Mobile.CreateSystem(battery, on, system);
        }
    }
}