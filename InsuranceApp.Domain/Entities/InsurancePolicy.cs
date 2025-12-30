using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Domain.Entities
{
    public class InsurancePolicy
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; } = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();

        // Thông tin xe
        public string LicensePlate { get; set; } = string.Empty; // Biển số
        public string VehicleType { get; set; } = string.Empty; // Xe ga, xe số...
        public string ChassisNumber { get; set; } = string.Empty; // Số khung

        // Thời hạn
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        // Người tạo đơn (Nhân viên/Kinh doanh)
        public string CreatedByUserId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
