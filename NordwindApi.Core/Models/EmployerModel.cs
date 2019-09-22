using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Models
{
    public class EmployerModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extensions { get; set; }
        public byte? Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportTo { get; set; }
        public string PhotoPath { get; set; }
    }
}
