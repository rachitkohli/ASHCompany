using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASH.Data.Repositories;
using ASH.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Data.Entity;
using ASH.DataTests.Repositories;

namespace ASH.Data.Repositories.Tests
{
    [TestClass()]
    public class WorkerRepositoryTests
    {
        [TestMethod()]
        public void AddNewWorkerTest()
        {
            var mockSet = new Mock<DbSet<Worker>>();

            var EmpList = new List<EmployeeDetail>()
            {
                new EmployeeDetail()
                {
                    EmpID=1,
                    ID=1,   //1 - Employee, 2 - Supervisor, 3 - Manager
                    PayperHour=50
                }
            };

            var worker = new Worker()
            {
                ID = 1,
                FirstName = "Mike",
                LastName = "Anderson",
                Address1 = "New York",
                EmployeeDetails = EmpList,
                WorkerTypeID = 1
            };

            Mock<IWorkerMoq> mockContext = new Mock<IWorkerMoq>();
            mockContext.Setup(m => m.AddNewWorker(It.IsAny<Worker>()));
            WorkerMoq workerMoq = new WorkerMoq();
            var result = workerMoq.AddNewWorkerMoq(mockContext.Object, worker);

            Assert.IsTrue(result == worker);
        }
    }
}