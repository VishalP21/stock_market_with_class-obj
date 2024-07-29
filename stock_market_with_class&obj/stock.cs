using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market_with_class_obj
{
    public class stock
    {
        public string stock_Name = "";
        public string stock_symbol = "";
        public double current_stock_price = 0;
        public double previous_stock_price = 0;

        public void input()
        {
            Console.WriteLine("enter stock name");
            stock_Name = Console.ReadLine();
            Console.WriteLine("enter stock symbole");
            stock_symbol = Console.ReadLine();
            Console.WriteLine("enter stock current price");
            current_stock_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter stock previous price");
            previous_stock_price = Convert.ToDouble(Console.ReadLine());

        }
        public void output()
        {
            Console.WriteLine(stock_Name);
            Console.WriteLine(stock_symbol);
            if(current_stock_price > previous_stock_price)
            {
                Console.WriteLine("you are in profit of "+(current_stock_price-previous_stock_price));
                Console.WriteLine("your profit in % is " + (((current_stock_price * 100) / previous_stock_price)-100)+"%");
            }
            else
            {
                Console.WriteLine("you are in loss of " + (previous_stock_price-current_stock_price));
                Console.WriteLine("your loss in % is " + (100 - ((current_stock_price * 100) / previous_stock_price))+"%");
            }
        }
    }
}
