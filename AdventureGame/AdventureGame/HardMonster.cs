using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class HardMonster : Monster
    {
        public HardMonster()
        {
            Random random = new Random();
            double a = random.Next(30, 60);
            base.Damage = a;
            double b = random.Next(30, 60);
            base.Protection = b;
            int c = random.Next(30, 60);
            base.Gold = c;

        }
    }
}
