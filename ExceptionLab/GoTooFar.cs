using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLab
{
    class GoTooFar
    {
        public static void TryArray()
        {
            int[] numArray = { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(numArray[i]);
                }
            }
            catch (IndexOutOfRangeException exRange)
            {
                Console.WriteLine("You have gone too far.\n"+ exRange.Message);
            }
        }
    }
}
