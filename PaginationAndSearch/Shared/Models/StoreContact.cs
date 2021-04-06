using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class StoreContact
    {
        public int CustomerId { get; set; }
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual Store Customer { get; set; }
    }
}
