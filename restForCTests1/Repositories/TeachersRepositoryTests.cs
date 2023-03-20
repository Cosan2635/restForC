using Microsoft.VisualStudio.TestTools.UnitTesting;
using restForC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restForC.Repositories.Tests
{
    [TestClass()]
    public class TeachersRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            TeachersRepository repo = new();
            Assert.AreEqual(2, repo.GetAll().Count);
        
        }
    }
}