using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class DiscountFactory
    {
        Discount discount;

        //Handles the selected discount
        public int HandleSelectedDiscount(UIDiscount uiDiscount, int currentTableColumn)
        {

            switch (uiDiscount)
            {
                case UIDiscount.NoDiscount:
                    discount = new NoDiscount();
                    break;
                case UIDiscount.TwentyDiscount:
                    discount = new TwentyDiscount();
                    break;
                case UIDiscount.FortyDiscount:
                    discount = new FortyDiscount();
                    break;
            }
           return discount.SelectTableColumn(currentTableColumn);
        }
       
    }
}