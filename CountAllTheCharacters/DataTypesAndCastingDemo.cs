using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAllTheCharacters
{
    public  class DataTypesAndCastingDemo
    {
        public static void Run()
        {
            string text = "Hei";
            int number = 42;
            float otherNumber = 4.2f;
            double someNumber = 4.2;
            char t = 't';
            decimal d = 123.45m;
            var l = 123l;

            number = (int)otherNumber;

            int tAsInt = 't';
            char c = (char)123;

            var int32 = Convert.ToInt32("42");

            //text = number;
            //someNumber = otherNumber;

        }
    }
}
