using Microsoft.VisualStudio.TestTools.UnitTesting;
using WConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WConsoleApp2;

namespace WConsoleApp2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void calcTest()
        {
            Project program = new Project();
            Assert.AreEqual(int.Parse(program.Caculator("3+8/2")), 7);
        }
    }
}