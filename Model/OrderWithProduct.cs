using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Model
{
    public class OrderWithProduct
    {
        public Guid OrderId { get; set; }
        public Product ProductId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

        public OrderWithProduct(){} // empty constructor
    }
}
