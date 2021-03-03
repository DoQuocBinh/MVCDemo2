using System;
using System.Collections.Generic;

#nullable disable

namespace MVCDemo2.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int? Category { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ImportedDate { get; set; }

        public virtual Category CategoryNavigation { get; set; }
    }
}
