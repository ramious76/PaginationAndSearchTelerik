using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class Contact
    {
        public Contact()
        {
            ContactCreditCards = new HashSet<ContactCreditCard>();
            Employees = new HashSet<Employee>();
            Individuals = new HashSet<Individual>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            StoreContacts = new HashSet<StoreContact>();
            VendorContacts = new HashSet<VendorContact>();
        }

        public int ContactId { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string EmailAddress { get; set; }
        public int EmailPromotion { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string AdditionalContactInfo { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ContactCreditCard> ContactCreditCards { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Individual> Individuals { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<StoreContact> StoreContacts { get; set; }
        public virtual ICollection<VendorContact> VendorContacts { get; set; }
    }
}
