using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Description: {Description}";
        }

    }

    public class CatFood : Product
    {
        public string Flavor { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Flavor: {Flavor}";
        }
    }
}
