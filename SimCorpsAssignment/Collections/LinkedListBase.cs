using System;
using System.Text;
using System.Linq;
using Collections.Elements;

namespace Collections
{
    public abstract class LinkedListBase<TNode> : ILinkedList<TNode> where TNode : NodeBase<TNode>
    {
        protected TNode head;

        #region Public Methods
                
        public virtual void Add(string text)
        {
            var last = Search(x => IsLast(x), head);
            var node = Insert(last, text);
            head ??= node;
        }
               
        public TNode GetFirst(string condition)
        {
            return GetFirst(condition, head);

        }
                
        public TNode GetSingle(string condition)
        {
            var first = GetFirst(condition, head);
            if (first == null) throw new Exception("Nothing found");
            var anotherOne = GetFirst(condition, first.Next);
            if (anotherOne != null) throw new Exception("Sequence contains more than one element");
            return first;
        }
                
        public void Delete(object node)
        {
            if (node == null) throw new Exception("No argument passed");
            if (!(node is TNode)) throw new Exception("Wrong argument type");
            Delete((TNode)node);
        }
                
        public string[] ToArray()
        {
            var size = Count();
            var array = new String[size];
            var node = head;
            int ii = 0;

            while (node != null)
            {
                array[ii] = node.Text;
                node = node.Next;
                ii++;
            }

            return array;
        }
        #endregion

        #region Protected Methods

        protected int Count(int count = 0, TNode startFrom = null)
        {
            startFrom ??= head;
            count++;
            if (IsLast(startFrom)) return count;
            return Count(count, startFrom.Next);
        }
        protected virtual bool IsLast(TNode node)
        {
            return node.Next == null;
        }

        /// <summary>
        /// Searches for first node that matches condition
        /// </summary>
        /// <param name="predicate">Match condition</param>
        /// <param name="startNode">Start search from</param>
        /// <returns>First node found. Null if nothing found</returns>
        protected TNode Search(Func<TNode, bool> predicate, TNode startNode)
        {
            if (startNode == null) return null;
            var start = startNode;
            return predicate(start)
                ? start
                : Search(predicate, start.Next);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="startNode"></param>
        /// <returns></returns>
        protected TNode GetFirst(string text, TNode startNode)
        {
            return Search(x => x.Text == text, startNode);
        }

        /// <summary>
        /// Inserts a node
        /// </summary>
        /// <param name="insetAfter"></param>
        /// <returns>Node inserted</returns>
        protected abstract TNode Insert(TNode insetAfter, string text);

        protected abstract void Delete(TNode node);

        #endregion
    }
}
