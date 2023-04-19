using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLStock
    {
        public System.Data.Linq.Table<Stock> TakeStock()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Stocks;
        }
        public bool AddStock(string batchID, DateTime imDate, int amountofProduct, string sID, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Stock sto = new Stock();
            sto.batchID = batchID;
            sto.imDate = imDate;
            sto.amountofProduct = amountofProduct;
            sto.sID = sID;
            qlMS.Stocks.InsertOnSubmit(sto);
            qlMS.Stocks.Context.SubmitChanges();
            return true;

        }
        public bool DeleteStock(ref string err, string batchID)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var stoQuery = from sto in qlMS.Stocks
                           where sto.batchID == batchID
                           select sto;
            qlMS.Stocks.DeleteAllOnSubmit(stoQuery);
            qlMS.SubmitChanges();
            return true;
        }
        public bool UpdateStock(string batchID, DateTime imDate, int amountofProduct, string sID, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var stoQuery = (from sto in qlMS.Stocks
                            where sto.batchID == batchID
                            select sto).SingleOrDefault();

            if (stoQuery != null)
            {
                stoQuery.imDate = imDate;
                stoQuery.amountofProduct = amountofProduct;
                stoQuery.sID = sID;
                qlMS.SubmitChanges();
            }
            return true;
        }
    }
}
