using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLDetail
    {
        public System.Data.Linq.Table<Detail> TakeDetail()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Details;
        }
        public bool AddDetail(string IDI, string IDP, int dAmount, float dPrice, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Detail inv = new Detail();
            inv.iID = IDI;
            inv.pID = IDP;
            inv.dAmount = dAmount;
            inv.dPrice = dPrice;
            qlMS.Details.InsertOnSubmit(inv);
            qlMS.Details.Context.SubmitChanges();
            return true;
        }
        public bool DeleteDetail(ref string err, string IDI, string IDP)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = from ma in qlMS.Details
                          where ma.iID == IDI && ma.pID == IDP 
                          select ma;
            qlMS.Details.DeleteAllOnSubmit(maQuery);
            qlMS.SubmitChanges();
            return true;
        }
        public bool UpdateDetail(string IDI, string IDP, int dAmount, float dPrice, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = (from ma in qlMS.Details
                           where ma.iID == IDI && ma.pID == IDP
                           select ma).SingleOrDefault();
            if (maQuery != null)
            {
                maQuery.dAmount = dAmount;
                maQuery.dPrice = dPrice;
                qlMS.SubmitChanges();
            }
            return true;
        }
    }
}
