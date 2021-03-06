namespace HellIf.ConsoleApp.Domain
{
    public class Mobile
    {
        public double Battery { get; private set; }
        public bool On { get; private set; }
        public string Owner { get; private set ; }

        private Mobile(double battery, bool on, string owner)
        {
            Battery = battery;
            On = on;
            Owner = owner;
        }

        public override string ToString()
        {
            return $"Onwer: {Owner}, Battery: {Battery}, On: {On}";
        }

        public static Mobile CreateSystem1()
        {
            return new Mobile(100, true, Constants.SYSTEM1);
        }

        public static Mobile CreateSystem2()
        {
            return new Mobile(0, false, Constants.SYSTEM2);
        }

        public static Mobile CreateSystem3()
        {
            return new Mobile(0, true, Constants.SYSTEM3);
        }

        public static Mobile CreateSystem(double battery, bool on, string owner)
        {
            return new Mobile(battery, on, owner);
        }
    }
}