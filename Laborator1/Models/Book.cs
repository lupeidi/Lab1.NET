using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator1.Models
{
    public class Book
    {
        public long Id { get; set;  }
        public string Title { get; set; }
        public int PublishingYear { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
