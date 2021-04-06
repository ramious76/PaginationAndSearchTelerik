using System;
using System.Collections.Generic;

#nullable disable

namespace PaginationAndSearch.Shared.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeAddresses = new HashSet<EmployeeAddress>();
            EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            EmployeePayHistories = new HashSet<EmployeePayHistory>();
            InverseManager = new HashSet<Employee>();
            JobCandidates = new HashSet<JobCandidate>();
            PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
        }

        public int EmployeeId { get; set; }
        public string NationalIdnumber { get; set; }
        public int ContactId { get; set; }
        public string LoginId { get; set; }
        public int? ManagerId { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public bool? SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool? CurrentFlag { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }
        public virtual ICollection<Employee> InverseManager { get; set; }
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
    }
}
