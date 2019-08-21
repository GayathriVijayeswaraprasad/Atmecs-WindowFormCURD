using BusinessEntity;
using DatabaseLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
    public class EmployeeLogic

    {
        DbConnection dbConnection;
        public EmployeeLogic()
        {
            dbConnection = new DbConnection();
        }
        public int InsertEmppersonal(EmpPersonal personal)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@Emp_Name",personal.EmpName),
                new SqlParameter("@Dob",personal.Dob),
                new SqlParameter("@Email_id",personal.EmailId),
                new SqlParameter("@Ph_No",personal.PhNo),
                new SqlParameter("@Address",personal.Address),
                new SqlParameter("@Gender",personal.gender)
            }, "InsertEmp");

        }
        public int UpdateEmppersonal(EmpPersonal personal)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@Emp_Id",personal.EmpId),
                new SqlParameter("@Emp_Name",personal.EmpName),
                new SqlParameter("@Dob",personal.Dob),
                new SqlParameter("@Email_id",personal.EmailId),
                new SqlParameter("@Ph_No",personal.PhNo),
                new SqlParameter("@Address",personal.Address),
                new SqlParameter("@Gender",personal.gender)
            }, "UpdateEmp");

        }
        public int DeleteEmppersonal(EmpPersonal personal)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@Emp_Id",personal.EmpId)
            }, "DeleteEmp");
        }
        public int InsertBankDetails(EmpBank empBank)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@DeptId",empBank.deptid),
                new SqlParameter("@Emp_Id",empBank.empid),
                new SqlParameter("@Bank",empBank.bank),
                new SqlParameter("@Bank_AcNo",empBank.acno),
                new SqlParameter("@Netpay",empBank.netpay),
                new SqlParameter("@PF_No",empBank.pfno),
                new SqlParameter("@PF_Amount",empBank.pfamt)
            }, "InsertBank");
        }
        public int UpdateBankDetails(EmpBank empBank)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@Emp_Id",empBank.empid),
                new SqlParameter("@DeptId",empBank.deptid),
                new SqlParameter("@Bank",empBank.bank),
                new SqlParameter("@Bank_AcNo",empBank.acno),
                new SqlParameter("@Netpay",empBank.netpay),
                new SqlParameter("@PF_No",empBank.pfno),
                new SqlParameter("@PF_Amount",empBank.pfamt)
            }, "UpdateBank");
        }
        public int DeleteBankDetails(EmpBank empBank)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@Emp_Id",empBank.empid)
            }, "DeleteBank");
        }
        public int InsertWorkDetails(EmpWork empWork)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@Emp_Id",empWork.empid),
                new SqlParameter("@DeptName",empWork.deptname),
                new SqlParameter("@DeptId",empWork.deptid),
                new SqlParameter("@Designation",empWork.designation),
                new SqlParameter("@Manager",empWork.manager),
                new SqlParameter("@Attendance",empWork.attendance),
                new SqlParameter("@Salary",empWork.salary),
                new SqlParameter("@Experience",empWork.experience)
            }, "InsertWork");

        }
        public int UpdateWorkDetails(EmpWork empWork)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@Emp_Id",empWork.empid),
                new SqlParameter("@DeptId",empWork.deptid),
                new SqlParameter("@Designation",empWork.designation),
                new SqlParameter("@Manager",empWork.manager),
                new SqlParameter("@Attendance",empWork.attendance),
                new SqlParameter("@Salary",empWork.salary),
                new SqlParameter("@Experience",empWork.experience),
                new SqlParameter("@DeptName",empWork.deptname)
            }, "UpdateWork");
        }
        public int DeleteWorkDetails(EmpWork empWork)
        {
            return dbConnection.SetValueInDb(new SqlParameter[]
            {
                new SqlParameter("@Emp_Id",empWork.empid)
            }, "DeleteWork");
        }
        public DataTable GetEmployeeRecord()
        {
           return dbConnection.GetRecordUsingProc("GetEmployeeDetails");
        }
    }
}




