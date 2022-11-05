using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.DTO
{
    public class CreateReviewDTO
    {
        public Guid ProductId { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
