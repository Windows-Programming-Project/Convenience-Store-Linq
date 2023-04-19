using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLType
    {
        public System.Data.Linq.Table<Type> TakeType()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Types;
        }
        public bool AddType(string tID, string tName, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Type ty = new Type();
            ty.tID = tID;
            ty.tName = tName;
            qlMS.Types.InsertOnSubmit(ty);
            qlMS.Types.Context.SubmitChanges();
            return true;

        }
        public bool DeleteType(ref string err, string tID)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var tyQuery = from ty in qlMS.Types
                          where ty.tID == tID
                          select ty;
            qlMS.Types.DeleteAllOnSubmit(tyQuery);
            qlMS.SubmitChanges();
            return true;
        }
        public bool UpdateType(string tID, string tName, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var tyQuery = (from ty in qlMS.Types
                           where ty.tID == tID
                           select ty).SingleOrDefault();

            if (tyQuery != null)
            {
                tyQuery.tName = tName;
                qlMS.SubmitChanges();
            }
            return true;
        }
    }
}
