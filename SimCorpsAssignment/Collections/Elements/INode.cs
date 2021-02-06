using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Elements
{
    public interface INode
    {
        INode Next { get; }
        string Text { get; set; }
    }
}
