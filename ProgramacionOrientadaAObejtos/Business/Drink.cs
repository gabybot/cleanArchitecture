using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaAObejtos.Business
{
    public abstract class Drink
    {
        public int Quantity { get; set; }
        public Drink(int quantity)
        {
            this.Quantity = quantity;
        }
        public string getMl()
        {
            return $"{Quantity} ml";
        }
    }
}
