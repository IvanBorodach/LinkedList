using Collections;
using Collections.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

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
