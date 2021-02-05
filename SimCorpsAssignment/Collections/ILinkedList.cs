using Collections.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public interface ILinkedList<out TNode> where TNode : INode
    {
        void Add(string text);
        TNode GetFirst(string condition); 
        TNode GetSingle(string condition);
        void Delete(object node);
        string[] ToArray();

    }
}
