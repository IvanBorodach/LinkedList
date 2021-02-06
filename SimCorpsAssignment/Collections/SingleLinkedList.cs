using Collections.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class SingleLinkedList : LinkedListBase<Node>
    {
        public SingleLinkedList(){ }

        protected override Node Insert(INode insertAfter, string text)
        {
            var newNode = new Node { Text = text };
            if (insertAfter != null) insertAfter.Next = newNode;
            return newNode;

        }
    }
}
