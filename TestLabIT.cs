using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_IT_Holiichuk
{
    [TestClass]
    class TestLabIT
    {
        [TestMethod]
        public void TestValueCreation()
        {
            Value value1 = new Value(217, "attribute1");
            Assert.AreEqual(value1.value, 217);
        }

        [TestMethod]
        public void TestValueType()
        {
            Value value2 = new Value("abcd", "attribute2");
            Assert.AreEqual(value2.valueType, "String");
        }

        [TestMethod]
        public void TestTableAttributes()
        {
            List<TableAttribute> tableAttributes = new List<TableAttribute>()
            {
                new TableAttribute("atribute1", null, "Int"),
                new TableAttribute("atribute2", null, "Int")
            };
            Table table1 = new Table(101, "table1", tableAttributes, null);
            Assert.AreEqual(table1.AttributeNames[1], "atribute2");
        }
    }
}