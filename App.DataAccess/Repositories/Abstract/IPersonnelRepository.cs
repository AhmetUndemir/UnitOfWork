using App.Domain;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repositories.Abstract
{
    public interface IPersonnelRepository : IRepository<Personnel>
    {
        IEnumerable<Personnel> GetPersonnelsWithDepartments();
    }
}
