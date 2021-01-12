using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASH.Model;
using ASH.Data.Repositories;

namespace ASH.API.Controllers
{
    public class WorkerController : ApiController
    {
        private IWorkerRepository workerRepository;
        private IUnitOfWork unitOfWork;

        public WorkerController()
        {
            workerRepository = new WorkerRepository();
            unitOfWork = new UnitOfWork();
        }


        // GET: api/Worker
        [HttpGet]
        public IEnumerable<Worker> GetAllWorkers()
        {
            return workerRepository.GetAllWorkers();
        }

        [HttpPost]
        public void AddWorker(Worker worker)
        {
            workerRepository.AddNewWorker(worker);
            unitOfWork.Save();
        }

        
    }
}
