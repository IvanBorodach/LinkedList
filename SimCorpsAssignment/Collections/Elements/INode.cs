using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Elements
{
    public interface INode
    {
        INode Next { get; internal set; }
        string Text { get; set; }
    }
}
