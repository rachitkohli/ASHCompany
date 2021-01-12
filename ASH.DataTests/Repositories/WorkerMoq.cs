using ASH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASH.DataTests.Repositories
{
    public interface IWorkerMoq
    {
        void AddNewWorker(Worker worker);
    }
    public class WorkerMoq
    {
        public Worker AddNewWorkerMoq(IWorkerMoq MoqDBContext, Worker worker)
        {
            MoqDBContext.AddNewWorker(worker);
            return worker;
        }
    }
}
