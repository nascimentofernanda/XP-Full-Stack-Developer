using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Stock
    {
        public int QuantityAvaliable { get; set; }
        public int QuantityWished { get; set; }

        public void Verify()
        {
            bool orderAproved = QuantityWished>0 && QuantityAvaliable>=QuantityWished;
            
            if(orderAproved)
            {
                Console.WriteLine("Your order will be prepared. Thank you for buying with us.");
            }
            else if (QuantityWished==0)
            {
                Console.WriteLine("Quantity Invalid.");
            }
            else
            {
                Console.WriteLine("I'm sorry but this quantity is not available.");
            }
        }
    }
}