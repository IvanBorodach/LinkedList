using Collections.Elements;

namespace Collections
{
    public class SingleLinkedList : LinkedListBase<Node>
    {
        public SingleLinkedList() { }

        protected override void Delete(Node node)
        {
            if (head == node)
            {
                head = (Node)node.Next;
            }
            else
            {
                var previous = Search(x => x.Next == node, head);
                previous.Next = node.Next;
            }
        }

        protected override Node Insert(Node insertAfter, string text)
        {
            var newNode = new Node { Text = text };
            if (insertAfter != null) insertAfter.Next = newNode;
            return newNode;

        }
    }
}
