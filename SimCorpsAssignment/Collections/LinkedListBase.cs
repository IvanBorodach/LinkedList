using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Collections
{
    public abstract class LinkedListBase<TNode>
    {
        /// <summary>
        /// Adds a new node to the end of the list
        /// </summary>
        /// <param name="node"></param>
        public virtual void Add(string text) 
        {
            var a = new List<string>();
            var b = a.ToArray();
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
        public void Delete(TNode node)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Copies the elements to a new array
        /// </summary>
        /// <returns>Array containing copies of elements in this list</returns>
        TNode[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
