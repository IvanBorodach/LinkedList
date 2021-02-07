using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Elements
{
    public class DoubleLinkedNode : BaseNode<DoubleLinkedNode>
    {
        public DoubleLinkedNode Previous { get; internal set; }        
    }
}
