using System;
using System.Text;
using System.Linq;
using Collections.Elements;

namespace Collections
{
    public abstract class LinkedListBase<TNode, TNodeIn> : ILinkedList<TNode> where TNode : INode 
    {
        /// <summary>
        /// Adds a new node to the end of the list
        /// </summary>
        /// <param name="node"></param>
        public virtual void Add(string text) 
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searches for a first node with matching text
        /// </summary>
        /// <param name="condition"></param>
        /// <returns>First matching node</returns>
        public TNode GetFirst(string condition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns matching node. Throws an exception if there's not exactly one element
        /// </summary>
        /// <param name="condition"></param>
        /// <returns>The single element in collection</returns>
        public TNode GetSingle(string condition)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes specified node from collection
        /// </summary>
        /// <param name="node">Node to delete</param>
        public void Delete(object node)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Node values in an array
        /// </summary>
        /// <returns>Array of node values</returns>
        public string[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
