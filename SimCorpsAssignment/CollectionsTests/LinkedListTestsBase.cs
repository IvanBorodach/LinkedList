using Collections;
using Collections.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace CollectionsTests
{
    [TestClass]
    public abstract class LinkedListTestsBase
    {
        protected ILinkedList<INode> list;

        [TestInitialize]
        public void Initialize()
        {
            list.Add("First");
            list.Add("Second");
            list.Add("Third");
            list.Add("Fourth");
            list.Add("Fifth");
        }

        [TestMethod]
        public void GetFirst_Fetches_RecordExists()
        {

        }

        [TestMethod]
        public void GetFirst_Fetches_NullRecordExists()
        {

        }

        [TestMethod]
        public void GetFirst_ReturnsNull_NoRecord()
        {

        }

        [TestMethod]
        public void GetSingle_Fetches_RecordExists()
        {

        }

        [TestMethod]
        public void GetSingle_Fetches_NullRecordExists()
        {

        }

        [TestMethod]
        public void GetSingle_Throws_NoRecord()
        {

        }

        [TestMethod]
        public void GetSingle_Throws_MoreThanOneRecord()
        {

        }

        [TestMethod]
        public void Delete_RemovesElement()
        {

        }

        [TestMethod]
        public void Delete_Throws_NoArgumentPassed()
        {

        }

        [TestMethod]
        public void ToArray_ReturnsSameNumberOfElements()
        {

        }

        [TestMethod]
        public void ToArray_ReturnsSameElements()
        {

        }
    }
}
