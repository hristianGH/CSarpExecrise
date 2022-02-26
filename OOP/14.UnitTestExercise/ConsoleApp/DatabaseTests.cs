using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ConsoleApp
{
    public class DatabaseTests
    {
        Database database; 
        [SetUp]
        public void Setup()
        {
             database = new Database(new int[] { 1, 2, 3, 4 });
        }

        [Test]
        public void AddOperation()
        {
            database.Add(5);
            Assert.That(database.Count, Is.EqualTo(5));
        }
    }
}
