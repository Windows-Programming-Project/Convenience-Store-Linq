using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLManuafacture
    {
        public System.Data.Linq.Table<Manuafacture> TakeManuafacture()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Manuafactures;
        }
        public bool AddManuafacture(string mID, string mName, string mLocation, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Manuafacture ma = new Manuafacture();
            ma.mID = mID;
            ma.mName = mName;
            ma.mLocation = mLocation;
            qlMS.Manuafactures.InsertOnSubmit(ma);
            qlMS.Manuafactures.Context.SubmitChanges();
            return true;

        }
        public bool DeleteManuafacture(ref string err, string mID)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = from ma in qlMS.Manuafactures
                          where ma.mID == mID
                          select ma;
            qlMS.Manuafactures.DeleteAllOnSubmit(maQuery);
            qlMS.SubmitChanges();
            return true;
        }
        public bool UpdateManuafacture(string mID, string mName, string mLocation, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = (from ma in qlMS.Manuafactures
                           where ma.mID == mID

                           select ma).SingleOrDefault();

            if (maQuery != null)
            {
                maQuery.mName = mName;
                maQuery.mLocation = mLocation;
                qlMS.SubmitChanges();
            }
            return true;
        }
    }
}
