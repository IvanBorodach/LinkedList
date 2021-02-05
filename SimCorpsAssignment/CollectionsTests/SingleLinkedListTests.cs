using Collections;
using Collections.Elements;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsTests
{
    [TestClass]
    public class SingleLinkedListTests : LinkedListTestsBase
    {
        public SingleLinkedListTests()
        {
            list = new SingleLinkedList();
        }

    }
}
