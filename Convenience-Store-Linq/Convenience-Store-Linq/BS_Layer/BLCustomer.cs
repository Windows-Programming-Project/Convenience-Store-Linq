using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
     class BLCustomer
    {
        public System.Data.Linq.Table<Customer> TakeCustomer()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Customers;
        }
        public bool AddCustomer(string cID, string cName, float TotalPay, string cPhone, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Customer Ctm = new Customer();
            Ctm.cID = cID;
            Ctm.cName = cName;
            Ctm.cTotalpay = TotalPay;
            Ctm.cPhoneNum = cPhone;
            qlMS.Customers.InsertOnSubmit(Ctm);
            qlMS.Customers.Context.SubmitChanges();
            return true;
        }
       
        public bool UpdateCustomer(string cID, string cName, float TotalPay, string cPhone, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = (from ma in qlMS.Customers
                           where ma.cID == cID
                           select ma).SingleOrDefault();
            if (maQuery != null)
            {
                maQuery.cID = cID;
                maQuery.cName = cName;
                maQuery.cTotalpay = TotalPay;
                maQuery.cPhoneNum = cPhone;
                qlMS.SubmitChanges();
            }
            return true;
        }
        public bool DeleteCustomer(string cID, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = from ma in qlMS.Customers
                          where ma.cID == cID
                          select ma;
            qlMS.Customers.DeleteAllOnSubmit(maQuery);
            qlMS.SubmitChanges();
            return true;
        }
    }
}
