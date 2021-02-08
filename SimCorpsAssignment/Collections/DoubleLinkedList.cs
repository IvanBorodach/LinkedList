using Collections.Elements;

namespace Collections
{
    public class DoubleLinkedList : LinkedListBase<DoubleLinkedNode>
    {
        public DoubleLinkedList() { }

        protected override void Delete(DoubleLinkedNode node)
        {
            if (head == node)
            {
                head = node.Next;
                node.Next.Previous = null;
            }
            else
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
            }
        }

        protected override DoubleLinkedNode Insert(DoubleLinkedNode insertAfter, string text)
        {
            var newNode = new DoubleLinkedNode { Text = text, Previous = insertAfter };
            if (insertAfter != null) insertAfter.Next = newNode;
            return newNode;
        }
    }
}
