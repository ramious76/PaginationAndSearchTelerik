using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            StoreContacts = new HashSet<StoreContact>();
            VendorContacts = new HashSet<VendorContact>();
        }

        public int ContactTypeId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<StoreContact> StoreContacts { get; set; }
        public virtual ICollection<VendorContact> VendorContacts { get; set; }
    }
}
