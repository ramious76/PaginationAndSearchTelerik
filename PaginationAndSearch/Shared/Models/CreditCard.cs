using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class CreditCard
    {
        public CreditCard()
        {
            ContactCreditCards = new HashSet<ContactCreditCard>();
            SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        }

        public int CreditCardId { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public byte ExpMonth { get; set; }
        public short ExpYear { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ContactCreditCard> ContactCreditCards { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
