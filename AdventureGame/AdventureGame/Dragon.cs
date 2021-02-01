using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Dragon : Monster
    {
        public Dragon():base(21,25,100000)
        {
            this.Health = 350;
        }
    }
}
