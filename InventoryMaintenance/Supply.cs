using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Supply inherits from InvItem, so it can use the properties and methods defined in the InvItem class.

    public class Supply: InvItem 
    {
       // Nady Fotie
        public Supply() { }

       // Nady Fotie
        public Supply(int itemNo, string description, decimal price, string manufacturer ) : base(itemNo, description, price)
        {
           Manufacturer = manufacturer;
        }

        // Nady Fotie
        public string Manufacturer{ get; set; }

        // Nady Fotie
        public override string GetDisplayText()
        {
           return base.GetDisplayText() + Manufacturer;


        }
    }

    
}
