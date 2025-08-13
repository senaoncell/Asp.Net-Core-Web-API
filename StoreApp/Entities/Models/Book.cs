using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public decimal BookPrice { get; set; }
        //Ref : navigation property
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
