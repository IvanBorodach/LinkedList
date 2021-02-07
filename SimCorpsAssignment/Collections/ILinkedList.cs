using Collections.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public interface ILinkedList<out TNode>
    {
        /// <summary>
        /// Adds a new element to the end of the list
        /// </summary>
        /// <param name="node">The element to append</param>
        void Add(string text);

        /// <summary>
        /// Searches for a first node with matching text
        /// </summary>
        /// <param name="condition"></param>
        /// <returns>First matching node</returns>
        TNode GetFirst(string condition);

        /// <summary>
        /// Returns matching node. Throws an exception if there's not exactly one element
        /// </summary>
        /// <param name="condition"></param>
        /// <returns>The single element in collection</returns>
        TNode GetSingle(string condition);

        /// <summary>
        /// Deletes specified node from collection
        /// </summary>
        /// <param name="node">Node to delete</param>
        void Delete(object node);

        /// <summary>
        /// Creates a new string array and fills it with node values
        /// </summary>
        /// <returns>Node values in an array</returns>
        string[] ToArray();

    }
}
