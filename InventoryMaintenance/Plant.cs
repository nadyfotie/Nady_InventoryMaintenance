using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Plant inherits from InvItem, so it can use the properties and methods defined in the InvItem class.
    public class Plant: InvItem
    {
       // Nady Fotie
        public Plant() { }
        public Plant(int itemNo, string description, decimal price, string size) : base (itemNo, description, price) {
            Size = size;


    }
        // Nady Fotie
        public string Size{ get; set; }

        // Nady Fotie
        public override string GetDisplayText()
        {
            return base.GetDisplayText() +  Size;
        }
    }

   
}
