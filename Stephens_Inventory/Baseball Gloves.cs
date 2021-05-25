using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stephens_Inventory
{
    class Baseball_Gloves : IShippable
    {
        private decimal _shipcost;
        private string _product;

        public Baseball_Gloves(Decimal ShipCost, string Product)
        {
            _shipcost = ShipCost;
            _product = Product;
        }
        public decimal ShipCost
        {
            get { return _shipcost; }
        }

        public string Product
        {
            get { return _product; }
        }
    }
}
