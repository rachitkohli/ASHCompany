using ASH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASH.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WorkersEntities _dbContext;
        private DbContextTransaction _tran;

        public UnitOfWork()
        {
            _dbContext = new WorkersEntities();
        }

        public void Save()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Data!", ex.InnerException);
            }
        }

        public WorkersEntities Context()
        {
            return _dbContext;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        // Can implement Transaction functionality as well
        public void CreateTransaction()
        {
            _tran = _dbContext.Database.BeginTransaction();
        }

        public void Rollback()
        {
            _tran.Rollback();
        }

        public void Commit()
        {
            _tran.Commit();
        }
    }
}
