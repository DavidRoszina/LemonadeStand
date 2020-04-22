using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfIceCubes;
        public int amountOfSugarCubes;
        public double pricePerCup;
        public Recipe()
        {
            amountOfLemons = 6;
            amountOfIceCubes = 8;
            amountOfSugarCubes = 30;
            pricePerCup = 1.25;
        }
    }
}
