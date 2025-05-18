using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria_NaMasaSTugai.Interfaces;

namespace Pizzaria_NaMasaSTugai.Classes
{
    public abstract class Pizza : IPizza
    {
        public string Name { get; protected set; }
        public string Size { get; protected set; }
        public int Quantity { get; protected set; }
        public string Toppings { get; protected set; }
        public int ToppingsWeight { get; protected set; }
        protected abstract Dictionary<string, int> sizePrices { get; }
        protected abstract Dictionary<string, int> doughWeight { get; }

        public Pizza(string size, int quantity)
        {
            Size = size.ToLower();
            Quantity = quantity;
        }
        public double GetPrice()
        {
            if (sizePrices.ContainsKey(Size))
            {
                return sizePrices[Size] * Quantity;
            }
            else
            {
                throw new ArgumentException("Invalid size for this pizza.");
            }
        }

        public virtual void Prepare()
        {
            Console.WriteLine($"{Name} preparing...");
            int dough = doughWeight[Size];
            int price = sizePrices[Size];

            Console.WriteLine($"Pizza dough {Quantity}*{dough} = {Quantity * dough}gr");
            Console.WriteLine($"{Toppings} {Quantity}*{ToppingsWeight} = {Quantity * ToppingsWeight}gr");
            Console.WriteLine($"Total: ${GetPrice()}");
            Console.WriteLine();
        }
    }
}