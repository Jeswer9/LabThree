using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class ClassFactory
    {
        Class cls;

        //Handles the selected class
        public int HandleSelectedClass(UIClass uiClass, int currentTableColumn)
        {
            switch (uiClass)
            {
                case UIClass.FirstClass:
                    cls = new FirstClass();
                    break;
                case UIClass.SecondClass:
                    cls = new SecondClass();
                    break;
            }

           return cls.SelectTableColumn( currentTableColumn);
        }
       
    }

}
