﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetSubjectTest()
        {
            Assert.IsNotNull(System.IO.File.ReadAllText(Program.path));
        }
    }
}