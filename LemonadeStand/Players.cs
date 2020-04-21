using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public Wallet wallet;

        public Player()
        {
            name = "David";
            wallet = new Wallet();
        }
    }
}
