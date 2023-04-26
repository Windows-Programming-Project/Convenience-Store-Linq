using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLProduct
    {
        public System.Data.Linq.Table<Product> TakeProduct()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Products;
        }
        public bool AddProduct(string pID, string pName, float pPrice, string tID, string batchID, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Product ma = new Product();
            ma.pID = pID;
            ma.pName = pName;
            ma.pPrice = pPrice;
            ma.tID = tID;
            ma.batchID = batchID;
            qlMS.Products.InsertOnSubmit(ma);
            qlMS.Products.Context.SubmitChanges();
            return true;

        }
        public bool DeleteProduct(ref string err, string pID, string tID, string batchID)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = from ma in qlMS.Products
                          where ma.pID == pID && ma.tID == tID && ma.batchID == batchID
                          select ma;
            qlMS.Products.DeleteAllOnSubmit(maQuery);
            qlMS.SubmitChanges();
            return true;
        }
        public bool UpdateProduct(string pID, string pName, float pPrice, string tID, string batchID, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = (from ma in qlMS.Products
                           where ma.pID == pID && ma.tID == tID && ma.batchID == batchID
                           select ma).SingleOrDefault();

            if (maQuery != null)
            {
                maQuery.pName = pName;
                maQuery.pPrice = pPrice;
                qlMS.SubmitChanges();
            }
            return true;
        }
    }
}
