using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMarket.Utility
{
    public static class SD
    {
        public const string Role_Customer = "Müşteri";
        public const string Role_Company = "Ticari";
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Çalışan";

		public const string StatusPending = "Beklemede";
		public const string StatusApproved = "Onaylandı";
		public const string StatusInProcess = "İşleniyor";
		public const string StatusShipped = "Kargoya verildi";
		public const string StatusCancelled = "İptal";
		public const string StatusRefunded = "İade";

		public const string PaymentStatusPending = "Beklemede";
		public const string PaymentStatusApproved = "Onaylandı";
		public const string PaymentStatusDelayedPayment = "Gecikmeli ödeme olarak onaylandı";
		public const string PaymentStatusRejected = "Reddedildi";
	}
}
