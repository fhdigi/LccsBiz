using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace LccsBiz.Std.Models
{
    public class Project : RealmObject
    {
        public Customer Customer { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double PurchaseOrderAmount { get; set; }

    }
}
