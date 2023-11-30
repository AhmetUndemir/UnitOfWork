using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    public class Personnel : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
