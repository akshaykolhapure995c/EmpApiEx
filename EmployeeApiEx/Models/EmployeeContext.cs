using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sql;

namespace EmployeeApiEx.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }

    }
}
