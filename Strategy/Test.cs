using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public static class Test
    {
        public static void Run()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.SetFlyBehavior(new FlyRocketPowered());
            mallardDuck.PerformFly();
        }
    }
}
