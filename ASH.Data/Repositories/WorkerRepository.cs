using ASH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASH.Data.Repositories
{
    public class WorkerRepository : IWorkerRepository, IDisposable
    {
        private readonly WorkersEntities _dbContext;

        public WorkerRepository()
        {
            _dbContext = new WorkersEntities();
        }

        public WorkerRepository(WorkersEntities context)
        {
            _dbContext = context;
        }

        public void AddNewWorker(Worker worker)
        {
            _dbContext.Workers.Add(worker);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Worker> GetAllWorkers()
        {
            return _dbContext.Workers.ToList();
        }
    }
}
