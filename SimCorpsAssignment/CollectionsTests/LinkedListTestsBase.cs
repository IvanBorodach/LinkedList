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
            var record = list.GetFirst("Third");
            Assert.IsNotNull(record);
        }

        [TestMethod]
        public void GetFirst_Fetches_NullRecordExists()
        {
            list.Add(null);
            var record = list.GetFirst(null);
            Assert.IsNotNull(record);
        }

        [TestMethod]
        public void GetFirst_ReturnsNull_NoRecord()
        {
            var record = list.GetFirst("NoSuchRecord");
            Assert.IsNull(record);
        }

        [TestMethod]
        public void GetSingle_Fetches_RecordExists()
        {
            var record = list.GetSingle("Third");
            Assert.IsNotNull(record);
        }

        [TestMethod]
        public void GetSingle_Fetches_NullRecordExists()
        {
            list.Add(null);
            var record = list.GetSingle(null);
            Assert.IsNotNull(record);
        }

        [TestMethod]
        public void GetSingle_Throws_NoRecord()
        {
            Assert.ThrowsException<Exception>(() => list.GetSingle("NoSuchREcord"));
        }

        [TestMethod]
        public void GetSingle_Throws_MoreThanOneRecord()
        {
            list.Add("Third");
            Assert.ThrowsException<Exception>(() => list.GetSingle("Third"));
        }

        [TestMethod]
        public void Delete_RemovesElement()
        {
            var toDelete = list.GetFirst("Third");
            list.Delete(toDelete);
            var deleted = list.GetFirst("Third");
            Assert.IsNull(deleted);
        }

        [TestMethod]
        public void Delete_DoesNotBreakChain()
        {
            var toDelete = list.GetFirst("Second");
            list.Delete(toDelete);
            var left = list.GetFirst("Fourth");
            Assert.IsNotNull(left);
        }

        [TestMethod]
        public void Delete_DoesNotBreakChain_RemovingHead()
        {
            var toDelete = list.GetFirst("First");
            list.Delete(toDelete);
            var left = list.GetFirst("Fifth");
            Assert.IsNotNull(left);
        }

        [TestMethod]
        public void Delete_Throws_NoArgumentPassed()
        {
            Assert.ThrowsException<Exception>(() => list.Delete(null));
        }

        [TestMethod]
        public void Delete_Throws_WrongObjectPassed()
        {
            Assert.ThrowsException<Exception>(() => list.Delete(new object()));
        }

        [TestMethod]
        public void ToArray_ReturnsSameNumberOfElements()
        {
            var array = list.ToArray();
            Assert.AreEqual(array.Length, 5);
        }

        [TestMethod]
        public void ToArray_ReturnsCorrectElements()
        {
            var array = list.ToArray();
            Assert.AreEqual(array[0], "First");
            Assert.AreEqual(array[1], "Second");
            Assert.AreEqual(array[2], "Third");
            Assert.AreEqual(array[3], "Fourth");
            Assert.AreEqual(array[4], "Fifth");
        }
    }
}
