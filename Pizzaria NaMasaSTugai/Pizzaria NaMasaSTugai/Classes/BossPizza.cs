using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria_NaMasaSTugai.Classes
{
  public class BossPizza : Pizza
{
    protected override Dictionary<string, int> sizePrices { get; } = new()
    {
        { "small", 20 },
        { "medium", 25 },
        { "large", 30 }
    };

    protected override Dictionary<string, int> doughWeight { get; } = new()
    {
        { "small", 300 },
        { "medium", 500 },
        { "large", 800 }
    };

    public BossPizza(string size, int quantity) : base(size, quantity)
    {
        Name = "Boss` Pizza";
            ToppingsWeight = 100;
            Toppings = "Ham";
        }
}
}
