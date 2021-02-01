using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class EasyMonster : Monster
    {
        public EasyMonster()
        {
            Random random = new Random();
            double a = random.Next(1, 15);
            base.Damage = a;
            double b = random.Next(1, 15);
            base.Protection = b;
            int c = random.Next(1, 15);
            base.Gold = c;

        }
    }
}
