
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Peliverkkokauppa;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class HttpTests
    {
        [TestMethod]
        public async void TestConnection()
        {
            DatabaseController databaseController = new DatabaseController();
            Boolean connectionSuccessful = await databaseController.testConnection();
            Assert.IsTrue(connectionSuccessful);
        }
    }
}
