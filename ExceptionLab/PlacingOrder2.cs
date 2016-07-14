using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLab
{
    class PlacingOrder2
    {
        public static void PlaceOrder2()
        {
            int stock = DataEntry();
            int quantity = DataEntry();
            Console.WriteLine("Stock: {0}\nQuantity: {1}", stock, quantity);
        }
        private static int DataEntry()
        {
            try
            {
                Console.Write("Enter value: ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "Invalid Input");
                return 0;
            }
        }
    }
}
