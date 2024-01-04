using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_git
{
    class Program
    {
        static void Main(string[] args)
        {

            //New Value = number - (1/100) * percent

            string sum = ((5928000) - (1 / 100) * 9).ToString();


            int n = 5;
            int sumf = 1;

           for(int i = n; i >=1; i--)
            {
                sumf *= i;
            }


            Console.WriteLine(sumf);
            Console.ReadKey();
        }
    }
}
