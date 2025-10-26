using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11_5
{
    internal class Product
    {
        private double price;
        private double discount;
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Цена не может быть отрицательной!");
                }
            }
        }
        public double Discount
        {
            get { return discount; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    discount = value;
                }
                else
                {
                    Console.WriteLine("Скидка должна быть в диапазоне 0-100%.");
                }
            }
        }
        public double FinalPrice
        {
            get { return price * (1 - discount / 100); }
        }
        public string Name { get; set; } = "Без названия";
        public Product(double price, double discount)
        {
            Price = price;
            Discount = discount;
        }
        public void Show()
        {
            Console.WriteLine($"{Name}: {FinalPrice:F0} (скидка {Discount}%)");
        }
    }

}
