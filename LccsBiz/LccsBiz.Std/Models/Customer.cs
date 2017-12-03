using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace LccsBiz.Std.Models
{
    public class Customer : RealmObject
    {
        public string CustomerName { get; set; }
    }
}
