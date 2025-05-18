using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_NaMasaSTugai.Classes
{
    public class MargaritaPizza : Pizza
    {
        protected override Dictionary<string, int> sizePrices { get; } = new()
    {
        { "small", 5 },
        { "medium", 10 },
        { "large", 15 }
    };

        protected override Dictionary<string, int> doughWeight { get; } = new()
    {
        { "small", 300 },
        { "medium", 500 },
        { "large", 800 }
    };

        public MargaritaPizza(string size, int quantity) : base(size, quantity)
        {
            Name = "Margarita";
            ToppingsWeight = 1;
            Toppings = "Tomatoes";
        }
        public override void Prepare()
        {
            Console.WriteLine($"{Name} preparing...");
            int dough = doughWeight[Size];
            int price = sizePrices[Size];

            Console.WriteLine($"Pizza dough {Quantity}*{dough} = {Quantity * dough}gr");
            Console.WriteLine($"{Toppings} {Quantity}*{ToppingsWeight} = {Quantity * ToppingsWeight}");
            Console.WriteLine($"Total: ${GetPrice()}");
            Console.WriteLine();
        }

    }



}
