using App.DataAccess.Repositories.Abstract;
using App.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PersonnelContext _context;
        public UnitOfWork(PersonnelContext context)
        {
            _context = context;
            DepartmentRepository = new DepartmentRepository(_context);
            PersonnelRepository = new PersonnelRepository(_context);
        }

        public IDepartmentRepository DepartmentRepository  { get; private set; }

        public IPersonnelRepository PersonnelRepository { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
