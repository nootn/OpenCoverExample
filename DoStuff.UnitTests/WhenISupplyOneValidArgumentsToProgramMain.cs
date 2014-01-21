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
    public class WhenISupplyOneValidArgumentsToProgramMain
    {

        private StringBuilder _output = new StringBuilder();

        [SetUp]
        public void Setup()
        {
            System.Console.SetOut(new StringWriter(_output));
            DoStuff.Console.Program.Main(new []{"test"});
        }

        [Test]
        public void ThenSomethingIsWrittenToConsole()
        {
            Assert.IsNotEmpty(_output.ToString());
        }

    }
}
