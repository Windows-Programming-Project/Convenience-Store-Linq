using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLInvoice
    {
        public System.Data.Linq.Table<Invoice> TakeInvoice()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Invoices;
        }
        public bool AddInvoice(string IDI, string IDE, string IDC, DateTime iDate, float iTotal, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Invoice inv = new Invoice();
            inv.iID = IDI;
            inv.eID = IDE;
            inv.cID = IDC;
            inv.iDate = iDate;
            inv.iTotalpay = iTotal;
            qlMS.Invoices.InsertOnSubmit(inv);
            qlMS.Invoices.Context.SubmitChanges();
            return true;

        }
        public bool DeleteInvoice(ref string err, string IDI, string IDE, string IDC)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = from ma in qlMS.Invoices
                          where ma.iID == IDI && ma.eID == IDE && ma.cID == IDC 
                          select ma;
            qlMS.Invoices.DeleteAllOnSubmit(maQuery);
            qlMS.SubmitChanges();
            return true;
        }
        public bool UpdateInvoice(string IDI, string IDE, string IDC, DateTime iDate, float iTotal, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = (from ma in qlMS.Invoices
                           where ma.iID == IDI && ma.eID == IDE && ma.cID == IDC
                           select ma).SingleOrDefault();
            if (maQuery != null)
            {
                maQuery.iDate = iDate;
                maQuery.iTotalpay = iTotal;
                qlMS.SubmitChanges();
            }
            return true;
        }
    }
}
