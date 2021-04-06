using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class ProductDocument
    {
        public int ProductId { get; set; }
        public int DocumentId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Document Document { get; set; }
        public virtual Product Product { get; set; }
    }
}
