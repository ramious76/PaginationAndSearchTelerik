using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class Individual
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public string Demographics { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
