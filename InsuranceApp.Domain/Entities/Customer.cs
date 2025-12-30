using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string IdentityCard { get; set; } = string.Empty; // CCCD

        // Quan hệ: 1 khách hàng có nhiều đơn bảo hiểm
        public ICollection<InsurancePolicy> Policies { get; set; } = new List<InsurancePolicy>();
    }
}
