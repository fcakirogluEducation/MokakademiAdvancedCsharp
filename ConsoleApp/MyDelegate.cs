using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


    public delegate int  Sum(int a, int b);
    internal class MyDelegate
    {

        public int Calculate(int a, int b, Sum Sum)
        {

            return Sum.Invoke(a, b);


        }






    }
}
