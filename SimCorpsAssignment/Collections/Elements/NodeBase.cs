namespace Collections.Elements
{
    public abstract class NodeBase<T> : INode
    {
        public T Next { get; internal set; }
        public string Text { get; set; }
    }
}
