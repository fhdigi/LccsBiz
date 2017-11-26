using System;
using System.Collections.Generic;
using System.Text;
using LccsBiz.Std.Models;

namespace LccsBiz.Std.PageModels
{
    public class HomePageModel : FreshMvvm.FreshBasePageModel
    {
        public string AccountName { get; set; }

        public HomePageModel()
        {
            /* Dummy seed */
            ChartOfAccount coa = ChartOfAccount.GetFirst();

            if (coa != null)
            {
                AccountName = coa.AccountName;
            }
        }
    }
}
