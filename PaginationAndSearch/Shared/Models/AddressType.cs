using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            CustomerAddresses = new HashSet<CustomerAddress>();
            VendorAddresses = new HashSet<VendorAddress>();
        }

        public int AddressTypeId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<VendorAddress> VendorAddresses { get; set; }
    }
}
