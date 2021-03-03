using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MVCDemo2.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int? Category { get; set; }

        [StringLength(10, MinimumLength = 5, ErrorMessage = "Min is 5 and max is 10")]
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ImportedDate { get; set; }

        public virtual Category CategoryNavigation { get; set; }
    }
}
