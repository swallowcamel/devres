using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Iterator
{
    public abstract class Aggregate
    {
           public abstract Iterator CreateIterator();
    }
}