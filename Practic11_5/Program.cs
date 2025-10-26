using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Phone = new Product(2000, 30);
            Phone.Show();
            Phone.Discount = 10;
            Phone.Show();
        }
    }
}
