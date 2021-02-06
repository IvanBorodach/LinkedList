using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Elements
{
    public class Node : INode
    {
        public INode Next { get; internal set; }
        public string Text { get; set; }
        
    }
}
