using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLSupplier
    {
        public System.Data.Linq.Table<Supplier> TakeSupplier()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Suppliers;
        }
        public bool AddSupplier(string sID, string mID, string sName, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Supplier sup = new Supplier();
            sup.sID = sID;
            sup.mID = mID;
            sup.sName = sName;
            qlMS.Suppliers.InsertOnSubmit(sup);
            qlMS.Suppliers.Context.SubmitChanges();
            return true;

        }
        public bool DeleteSupplier(ref string err, string sID)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var supQuery = from sup in qlMS.Suppliers
                           where sup.sID == sID
                           select sup;
            qlMS.Suppliers.DeleteAllOnSubmit(supQuery);
            qlMS.SubmitChanges();
            return true;
        }
        public bool UpdateSupplier(string sID, string mID, string sName, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var supQuery = (from sup in qlMS.Suppliers
                            where sup.sID == sID
                            select sup).SingleOrDefault();

            if (supQuery != null)
            {
                supQuery.mID = mID;
                supQuery.sName = sName;
                qlMS.SubmitChanges();
            }
            return true;
        }
    }
}
