﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_library
{
    public class CandyCreator : Creator
    {
        public override Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, TypeCandy type)
        {
            return new Candy(candyName, candyWeight, candySugar, candyCalories, type);
        }
        public override Sweet FactoryMethod(string candyName, int candyWeight, int candySugar, int candyCalories, ChocolateColor color)
        {
            throw new NotImplementedException();
        }

    }
}
