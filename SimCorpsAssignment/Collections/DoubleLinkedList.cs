using Collections.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class DoubleLinkedList : LinkedListBase<DoubleLinkedNode, DoubleLinkedNode>
    {
        public DoubleLinkedList() { }

        protected override DoubleLinkedNode Insert(INode insertAfter, string text)
        {
            var newNode = new DoubleLinkedNode { Text = text, Previous = insertAfter};
            if (insertAfter != null) insertAfter.Next = newNode;
            return newNode;
        }
    }
}
