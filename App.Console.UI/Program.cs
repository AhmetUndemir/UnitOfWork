using App.DataAccess;
using App.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Console.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            var data = new Department {Id = 1, Name = "Bilgi İşlem", IsActive = true, CreatedDate = DateTime.Now, DeleteDate = DateTime.Now,UpdatedDate = DateTime.Now };
            unitOfWork.DepartmentRepository.Add(data);
            unitOfWork.Complete();

        }
    }
}
