using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria_NaMasaSTugai.Classes;

namespace Pizzaria_NaMasaSTugai.Interfaces
{
    public interface IPizza
    {
        public string Name { get; }
        public string Size { get; }
        public int Quantity { get; }
        public int ToppingsWeight { get; }
        public double GetPrice();
        public void Prepare();
    }

}
