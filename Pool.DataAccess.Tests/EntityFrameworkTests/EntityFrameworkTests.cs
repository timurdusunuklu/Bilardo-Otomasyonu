using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pool.DataAccess.Concrete.EntityFramework;
using Pool.Core.DataAccess.EntityFramework;
using System;

namespace Pool.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTests
    {
        [TestMethod]
        public void Get_All_Tests()
        {
            EfMasaDal efMasaDal = new EfMasaDal();
           var result= efMasaDal.GetList();
            Assert.AreEqual(1, result.Count);
        }
    }
}
