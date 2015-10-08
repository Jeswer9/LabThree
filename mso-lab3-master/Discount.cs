using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public abstract class Discount
    {
        public abstract int SelectTableColumn(int currentColumn);

    }

    class NoDiscount : Discount
    {
        public override int SelectTableColumn(int currentColumn)
        {
            return currentColumn;
        }
    }

    class TwentyDiscount : Discount
    {
        public override int SelectTableColumn(int currentColumn)
        {
            return currentColumn + 1;
        }
    }

    class FortyDiscount : Discount
    {
        public override int SelectTableColumn(int currentColumn)
        {
            return currentColumn + 2;
        }
    }
}
