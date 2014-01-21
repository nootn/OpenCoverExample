using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DoStuff.UnitTests
{
    [TestFixture]
    public class WhenISupplyNoArgumentsToProgramMain
    {

        private StringBuilder _output = new StringBuilder();

        [SetUp]
        public void Setup()
        {
            System.Console.SetOut(new StringWriter(_output));
            DoStuff.Console.Program.Main(null);
        }

        [Test]
        public void ThenNothingIsWrittenToConsole()
        {
            Assert.IsEmpty(_output.ToString());
        }

    }
}
