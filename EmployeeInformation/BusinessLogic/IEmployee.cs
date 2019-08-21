using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEmployee
    {
        int InsertEmppersonal(EmpPersonal personal);
        int UpdateEmppersonal(EmpPersonal personal);
        int DeleteEmppersonal(EmpPersonal personal);
        int InsertBankDetails(EmpBank empBank);
        int UpdateBankDetails(EmpBank empBank);
        int DeleteBankDetails(EmpBank empBank);
        int InsertWorkDetails(EmpWork empWork);
        int UpdateWorkDetails(EmpWork empWork);
        int DeleteWorkDetails(EmpWork empWork);
    }
}
