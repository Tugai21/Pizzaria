using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria_NaMasaSTugai.Interfaces;

namespace Pizzaria_NaMasaSTugai.Classes
{
    public class Order
    {
        public IPizza Pizza { get; set; }
        public DateTime Date { get; set; }

        public Order(IPizza pizza, DateTime date)
        {
            Pizza = pizza;
            Date = date;
        }
    }
}
