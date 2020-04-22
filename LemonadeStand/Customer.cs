using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Customer
    {
        //Member Variables
        public bool willCustomerBuy;
        public int currentTemp;
        
        //Constructor
        public Customer()
        {

        }
        //Methods
        public void CustomerDecision()
        {
            var temp = new Random();
            int currentTemp = temp.Next(30, 100);

            if (currentTemp >= 60)
            {
                willCustomerBuy = false;
            }
            else willCustomerBuy = true;

        }
    }
}
