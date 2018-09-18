using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.DataSets.Implementations.Trees;

namespace Practice.DataSets.Implementations.SkipList
{
    public class SkipListNodeList<T> : NodeList<T>
    {
        public SkipListNodeList(int height) : base(height) { }
    }
}
