using App.DataAccess.Repositories.Abstract;
using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repositories.Concrete
{
    public class PersonnelRepository : Repository<Personnel>, IPersonnelRepository
    {
        public PersonnelRepository(PersonnelContext context) : base(context)
        {

        }
        public IEnumerable<Personnel> GetPersonnelsWithDepartments()
        {
            return PersonnelContext.Personnels.Include("Department").ToList();
        }

        public PersonnelContext PersonnelContext
        {
            get { return _context as PersonnelContext; }
        }

    }
}
