using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    abstract class Class
    {
        public abstract int SelectTableColumn(int currentColumn);
    }

    class FirstClass : Class
    {
        public override int SelectTableColumn(int currentColumn)
        {
            return currentColumn = 3;
        }
    }

    class SecondClass : Class
    {
        public override int SelectTableColumn(int currentColumn)
        {
            return currentColumn = 0;
        }
    }
}
