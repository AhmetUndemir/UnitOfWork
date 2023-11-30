using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Personnels = new List<Personnel>();
        }

        public string Name { get; set; }
        public ICollection<Personnel> Personnels { get; set; }
    }
}
