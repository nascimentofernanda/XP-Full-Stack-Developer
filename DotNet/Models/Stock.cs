using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Stock
    {
        public int quantityAvaliable { get; set; }
        public int quantityWished { get; set; }

        public void Verify()
        {
            bool orderAproved = quantityWished>0 && quantityAvaliable>=quantityWished;
            
            if(orderAproved)
            {
                Console.WriteLine("Your order will be prepared. Thank you for buying with us.");
            }
            else if (quantityWished==0)
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