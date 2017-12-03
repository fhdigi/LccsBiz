using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using LccsBiz.Std.Models;

namespace LccsBiz.Std.PageModels
{
    public class ReceivablesPageModel : FreshMvvm.FreshBasePageModel
    {
        public ObservableCollection<ViewItemListing> MainItemList { get; set; }

        public ReceivablesPageModel()
        {
            MainItemList = new ObservableCollection<ViewItemListing>
            {
                new ViewItemListing("Customers.png", "Customers", "Add, edit or delete the current customer list")
            };
        }
    }
}
