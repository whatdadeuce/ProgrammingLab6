using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLab
{
    class PlacingOrder
    {
        public static void PlaceOrder()
        {
            try
            {
                Console.Write("Enter a stock number: ");
                int stock = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Stock: {0}\nQuantity: {1}", stock, quantity);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message +"\nEnter a valid number.");
            }
        }
    }
}
