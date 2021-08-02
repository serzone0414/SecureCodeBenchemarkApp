using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SecureCodeBenchemarkApp;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class CreatureUnitTest
    {
        [TestMethod]
        public void TestCreatureCreatureName()
        {
            Creature c = new Creature();
            c.CreatureName = "Fluffy";
            Assert.AreEqual("Fluffy", c.CreatureName);
        }

        [TestMethod]
        public void TestCreatureAge()
        {
            Creature c = new Creature();
            c.Age = 123;
            Assert.AreEqual(123, c.Age);
        }

        [TestMethod]
        public void TestCreatureOwner()
        {
            Creature c = new Creature();
            c.Owner = "David";
            Assert.AreEqual("David", c.Owner);
        }

        [TestMethod]
        public void TestCreatureConstructor()
        {
            Creature c = new Creature();
            Assert.AreEqual("NA", c.Owner);
            Assert.AreEqual(0, c.Age);
            Assert.AreEqual("NA", c.CreatureName);
        }

        [TestMethod]
        public void TestCreatureToString()
        {
            Creature c = new Creature();
            Assert.AreEqual("NA", c.ToString());
        }
    }

    [TestClass]
    public class FilterUnitTest
    {
        [TestMethod]
        public void TestFilterSortingAZ()
        {
            Creature c1 = new Creature();
            c1.CreatureName = "c1";
            c1.Age = 10;
            c1.Owner = "c1 owner";

            Creature c2 = new Creature();
            c2.CreatureName = "c2";
            c2.Age = 10;
            c2.Owner = "c2 owner";

            Creature c3 = new Creature();
            c3.CreatureName = "c3";
            c3.Age = 10;
            c3.Owner = "c3 owner";

            Creature c4 = new Creature();
            c4.CreatureName = "c4";
            c4.Age = 10;
            c4.Owner = "c4 owner";

            List<Creature> cListExpected = new List<Creature>();
            cListExpected.Add(c1);
            cListExpected.Add(c2);
            cListExpected.Add(c3);
            cListExpected.Add(c4);

            List<Creature> cList = new List<Creature>();
            cList.Add(c2);
            cList.Add(c1);
            cList.Add(c4);
            cList.Add(c3);

            Filter f = new Filter();
            cList = f.SortAZ(cList);
            CollectionAssert.AreEqual(cListExpected, cList);
        }

        [TestMethod]
        public void TestFilterSortingZA()
        {
            Creature c1 = new Creature();
            c1.CreatureName = "c1";
            c1.Age = 10;
            c1.Owner = "c1 owner";

            Creature c2 = new Creature();
            c2.CreatureName = "c2";
            c2.Age = 10;
            c2.Owner = "c2 owner";

            Creature c3 = new Creature();
            c3.CreatureName = "c3";
            c3.Age = 10;
            c3.Owner = "c3 owner";

            Creature c4 = new Creature();
            c4.CreatureName = "c4";
            c4.Age = 10;
            c4.Owner = "c4 owner";

            List<Creature> cListExpected = new List<Creature>();
            cListExpected.Add(c4);
            cListExpected.Add(c3);
            cListExpected.Add(c2);
            cListExpected.Add(c1);

            List<Creature> cList = new List<Creature>();
            cList.Add(c2);
            cList.Add(c1);
            cList.Add(c4);
            cList.Add(c3);

            Filter f = new Filter();
            cList = f.SortZA(cList);
            CollectionAssert.AreEqual(cListExpected, cList);
        }

        [TestMethod]
        public void TestFilterSearch()
        {
            Creature c1 = new Creature();
            c1.CreatureName = "c1";
            c1.Age = 10;
            c1.Owner = "c1 owner";

            Creature c2 = new Creature();
            c2.CreatureName = "c2";
            c2.Age = 10;
            c2.Owner = "c2 owner";

            Creature c3 = new Creature();
            c3.CreatureName = "c3";
            c3.Age = 10;
            c3.Owner = "c3 owner";

            Creature c4 = new Creature();
            c4.CreatureName = "c4";
            c4.Age = 10;
            c4.Owner = "c4 owner";

            List<Creature> cListExpected = new List<Creature>();
            cListExpected.Add(c1);

            List<Creature> cList = new List<Creature>();
            cList.Add(c2);
            cList.Add(c1);
            cList.Add(c4);
            cList.Add(c3);

            Filter f = new Filter();
            cList = f.Search(cList,"1");
            CollectionAssert.AreEqual(cListExpected, cList);
        }

    }
}
