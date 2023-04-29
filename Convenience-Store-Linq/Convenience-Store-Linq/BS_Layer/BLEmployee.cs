using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convenience_Store_Linq.BS_Layer
{
    class BLEmployee
    {
        public System.Data.Linq.Table<Employee> TakeEmployee()
        {
            DataSet ds = new DataSet();
            CStoreDataContext qlMS = new CStoreDataContext();
            return qlMS.Employees;
        }
        public bool AddEmployee(string EID, string EName, DateTime EDateOfBirth, bool EGender, string EPhone, string EAddress, string EPosition, float ESalary, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            Employee Emp = new Employee();
            Emp.eID = EID;
            Emp.eName = EName;
            Emp.eBirthdate = EDateOfBirth;
            Emp.eGender = EGender;
            Emp.ePhone = EPhone;
            Emp.eAddress = EAddress;
            Emp.ePosition = EPosition;
            Emp.eSalary = ESalary;
            qlMS.Employees.InsertOnSubmit(Emp);
            qlMS.Employees.Context.SubmitChanges();
            return true;
        }
        public bool DeleteEmployee(string eID, ref string err )
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = from ma in qlMS.Employees
                          where ma.eID == eID 
                          select ma;
            qlMS.Employees.DeleteAllOnSubmit(maQuery);
            qlMS.SubmitChanges();
            return true;
        }
        public bool UpdateEmployee(string EID, string EName, DateTime EDateOfBirth, bool EGender, string EPhone, string EAddress, string EPosition, float ESalary, ref string err)
        {
            CStoreDataContext qlMS = new CStoreDataContext();
            var maQuery = (from ma in qlMS.Employees
                           where ma.eID == EID 
                           select ma).SingleOrDefault();
            if (maQuery != null)
            {
                maQuery.eName = EName;
                maQuery.eBirthdate = EDateOfBirth;
                maQuery.eGender = EGender;
                maQuery.ePhone = EPhone;
                maQuery.eAddress = EAddress;
                maQuery.ePosition = EPosition;
                maQuery.eSalary = ESalary;
                qlMS.SubmitChanges();
            }
            return true;
        }

    }
}
