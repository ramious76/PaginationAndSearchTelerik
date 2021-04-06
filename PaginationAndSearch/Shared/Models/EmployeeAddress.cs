using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class EmployeeAddress
    {
        public int EmployeeId { get; set; }
        public int AddressId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
