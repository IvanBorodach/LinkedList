using System;
using System.Text;
using System.Linq;
using Collections.Elements;

namespace Collections
{
    public abstract class LinkedListBase<TNode, TNodeIn> : ILinkedList<TNode> where TNode : INode
    {
        protected TNode head;

        #region Public Methods
        /// <summary>
        /// Adds a new node to the end of the list
        /// </summary>
        /// <param name="node"></param>
        public virtual void Add(string text)
        {            
            var last = Traverse(x => IsLast(x), head);
            var node = Insert(last, text);
            head = head ?? node;
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
        #endregion


        #region Protected Methods
        protected virtual bool IsLast(INode node)
        {
            return node.Next == null;
        }

        /// <summary>
        /// Searches for first node that matches condition
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="startNode"></param>
        /// <returns>First node found. Null if nothing found</returns>
        protected INode Traverse(Func<INode, bool> predicate, INode startNode)
        {
            if (startNode == null) return null;
            return predicate(startNode)
                ? startNode
                : Traverse(predicate, startNode.Next);
        }

        /// <summary>
        /// Inserts a node
        /// </summary>
        /// <param name="insetAfter"></param>
        /// <returns>Node inserted</returns>
        protected abstract TNode Insert(INode insetAfter, string text);

        #endregion
    }
}
