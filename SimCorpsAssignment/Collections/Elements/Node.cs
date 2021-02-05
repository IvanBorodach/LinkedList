using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Elements
{
    public class Node : INode
    {
        INode INode.Next { get; set; }
        public string Text { get; set; }
        
    }
}
