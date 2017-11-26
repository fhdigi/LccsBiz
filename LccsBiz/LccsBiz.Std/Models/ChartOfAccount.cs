using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Realms;

namespace LccsBiz.Std.Models
{
    public class ChartOfAccount : RealmObject
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int Grouping { get; set; }

        public static void Seed()
        {
            ChartOfAccount coa = new ChartOfAccount
            {
                AccountNumber = "100100",
                AccountName = "Checking",
                Grouping = 1
            };

            var realm = Realm.GetInstance();

            realm.Write(() =>
            {
                realm.Add(coa);
            });
        }

        public static ChartOfAccount GetFirst()
        {
            var realm = Realm.GetInstance();
            ChartOfAccount coa  = realm.All<ChartOfAccount>().FirstOrDefault();
            return coa;
        }
    }
}
