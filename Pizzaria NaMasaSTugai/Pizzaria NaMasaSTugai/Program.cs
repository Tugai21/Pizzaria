using Pizzaria_NaMasaSTugai.Classes;
using Pizzaria_NaMasaSTugai.Interfaces;

List<Order> orders = new();
string input;

while ((input = Console.ReadLine()).ToLower() != "end")
{
    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (parts.Length < 5) continue;

    string pizzaType = $"{parts[1]} {(parts[2] == "Pizza" ? parts[2] : "")}".Trim();
    int quantity = int.Parse(parts[2] == "Pizza" ? parts[3] : parts[2]);
    string size = parts[2] == "Pizza" ? parts[4] : parts[3];
    DateTime date = DateTime.Parse(parts[parts.Length-1]);
    IPizza pizza;
    switch (pizzaType.ToLower())
    {
        case "margarita":
            pizza = new MargaritaPizza(size, quantity);
            orders.Add(new Order(pizza, date));
            break;
        case "boss` pizza":
            pizza = new BossPizza(size, quantity);
            orders.Add(new Order(pizza, date));
            break;
        default:
            Console.WriteLine($"Unknown pizza type: {pizzaType}");
            continue;
    }
}
Console.WriteLine("\nOutput:");
foreach (Order order in orders)
{
    order.Pizza.Prepare();
}

Console.WriteLine("\nCash register reset:");

var grouped = orders.GroupBy(o => o.Date.ToShortDateString());

foreach (var group in grouped)
{
    Console.WriteLine(group.Key);
    Console.WriteLine($"Total pizzas {group.Count()}");

    int margaritaCount = group.Count(o => o.Pizza.Name == "Margarita");
    int bossCount = group.Count(o => o.Pizza.Name == "Boss` Pizza");
    double total = group.Sum(o => o.Pizza.GetPrice());

    Console.WriteLine($"Margarita {margaritaCount}");
    Console.WriteLine($"Boss` Pizza {bossCount}");
    Console.WriteLine($"Total Income = ${total}");
    Console.WriteLine();
}