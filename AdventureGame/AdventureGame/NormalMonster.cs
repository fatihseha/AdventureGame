using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class NormalMonster : Monster
    {
        public NormalMonster()
        {
            Random random = new Random();
            double a = random.Next(15, 30);
            base.Damage = a;
            double b = random.Next(15, 30);
            base.Protection = b;
            int c = random.Next(15, 30);
            base.Gold = c;

        }
    }
}
