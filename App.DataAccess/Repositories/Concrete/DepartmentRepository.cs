using App.DataAccess.Repositories.Abstract;
using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonnelContext context) : base(context)
        {

        }

        public IEnumerable<Department> GetDepartmentsWithPersonnels()
        {
            return PersonnelContext.Departments.Include("Personnels").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonnelContext.Departments.Take(count).ToList();
        }

        public PersonnelContext PersonnelContext
        {
            get { return _context as PersonnelContext; }
        }

    }
}
