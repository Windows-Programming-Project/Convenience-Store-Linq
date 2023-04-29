using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLAccount
    {
        public System.Data.Linq.Table<Account> TakeAccount()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Accounts;
        }
        public bool AddAccount(string aUsername, string aPassword, string eID, string aEmail, bool Active, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
           Account account = new Account();
            account.aUsername = aUsername;
            account.aPassword = aPassword;
            account.eID = eID;
            account.aEmail = aEmail;
            qlMS.Accounts.InsertOnSubmit(account);
            qlMS.Accounts.Context.SubmitChanges();
            return true;
        }

        public bool UpdateAccount(string aUsername, string aPassword, string eID, string aEmail, bool Active, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = (from ma in qlMS.Accounts
                           where ma.aUsername == aUsername
                           select ma).SingleOrDefault();
            if (maQuery != null)
            {
                maQuery.aUsername = aUsername;
                maQuery.aPassword = aPassword;
                maQuery.eID = eID;
                maQuery.aEmail = aEmail;
                qlMS.SubmitChanges();
            }
            return true;
        }
        public bool DeleteAccount(string aUsername, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = from ma in qlMS.Accounts
                          where ma.aUsername == aUsername
                          select ma;
            qlMS.Accounts.DeleteAllOnSubmit(maQuery);
            qlMS.SubmitChanges();
            return true;
        }
    }
}
