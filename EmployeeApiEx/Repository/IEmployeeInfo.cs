
using EmployeeApiEx.Models;

namespace EmployeeApiEx.Repository
{
    public interface IEmployeeInfo
    {
        IEnumerable<EmployeeInfo> GetAllEmployee();
        void AddEmployee( EmployeeInfo rec);
        EmployeeInfo GetEmployee(int id);
        void EditEmployee(EmployeeInfo rec);
        void Delete(Int64 id);
    }
}