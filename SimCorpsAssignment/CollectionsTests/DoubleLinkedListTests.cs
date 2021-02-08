using Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionsTests
{
    [TestClass]
    public class DoubleLinkedListTests : LinkedListTestsBase
    {
        public DoubleLinkedListTests()
        {
            list = new DoubleLinkedList();
        }
    }
}
