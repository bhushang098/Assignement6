using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement6._2
{
    internal class Program2
    {
        public static void Main(string[] a)
        {
            var age = 40;

            if(age >= 35){

                Console.WriteLine("You can vote and hold any place in government!");

            } else if (age >= 30)
            {

                Console.WriteLine("You can vote and run for the senate !") ;

            }
            else if(age >= 18){

                Console.WriteLine("You can vote!");

            }else
            {

                Console.WriteLine("You have no voice in government!");

            }
        }
    }
}
