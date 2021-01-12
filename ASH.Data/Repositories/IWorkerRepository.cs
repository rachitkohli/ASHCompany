using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASH.Model;

namespace ASH.Data.Repositories
{
    public interface IWorkerRepository
    {
        IEnumerable<Worker> GetAllWorkers();
        void AddNewWorker(Worker worker);
    }
}
