using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money o1 = new Money(500, CurrencyTypes.USD);
            Money o2 = new Money(200, CurrencyTypes.UAH);

            // 11) do operations
            // add 2 objects of Money
            Money o3 = o1 + o2;
            Console.WriteLine(o3.Amount.ToString() + "  " + o3.CurrencyType.ToString());
            // add 1st object of Money and double
            Money o4 = o1 * o1;
            Console.WriteLine(o4.Amount.ToString() + "  " + o4.CurrencyType.ToString());
            // decrease 2nd object of Money by 1 
            Money o5 = o2--;
            Console.WriteLine(o5.Amount.ToString() + "  " + o5.CurrencyType.ToString());
            // increase 1st object of Money
            Money o6 = o1 * o2;
            Console.WriteLine(o6.Amount.ToString() + "  " + o6.CurrencyType.ToString());
            // compare 2 objects of Money
            bool tr = o1 > o2;
            Console.WriteLine(tr.ToString());
            // compare 2nd object of Money and string

            // check CurrencyType of every object
            if (o1)
            Console.WriteLine("O1(true) UAN");
            if (o2)
            Console.WriteLine("O2(true) UAN");
            // convert 1st object of Money to string
            string currency = o1;
            Console.WriteLine(currency);
            Console.ReadKey();
        }
    }
}
