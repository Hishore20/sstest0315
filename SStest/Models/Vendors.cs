//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SStest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendors
    {
        public Vendors()
        {
            this.PurchaseOrders = new HashSet<PurchaseOrders>();
        }
    
        public int Vendor_ID { get; set; }
        public string VendorName { get; set; }
        public string UnifiedBusinessNumber { get; set; }
        public string Representative { get; set; }
        public string TelPhone { get; set; }
        public string Fax { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string DeliveryAddress { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> LastDeliveryDate { get; set; }
        public string Comment { get; set; }
    
        public virtual ICollection<PurchaseOrders> PurchaseOrders { get; set; }
    }
}