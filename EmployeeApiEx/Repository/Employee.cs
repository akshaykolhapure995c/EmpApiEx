using EmployeeApiEx.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApiEx.Repository
{
    public class Employee : IEmployeeInfo
    {
        EmployeeContext ec;
        public Employee(EmployeeContext temp)
        {
            this.ec = temp;
        }

        public void AddEmployee(EmployeeInfo rec)
        {
             
            ec.EmployeeInfos.Add(rec);
            ec.SaveChanges();


        }

        public void Delete(Int64 id)
        {
            var rec = ec.EmployeeInfos.Find(id);
            ec.EmployeeInfos.Remove(rec);
            ec.SaveChanges();
        }

        public void EditEmployee(EmployeeInfo rec)
        {
            ec.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ec.SaveChanges();
        }

        public IEnumerable<EmployeeInfo> GetAllEmployee()
        {
            return ec.EmployeeInfos.ToList();
        }

        public EmployeeInfo GetEmployee(int id)
        {
            return ec.EmployeeInfos.Find(id);
        }

    }
}
