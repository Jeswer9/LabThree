using System;

namespace Lab3
{
    class Cash : Payment
    {
        public override void HandlePayment(float price)
        {
            IKEAMyntAtare2000 c = new IKEAMyntAtare2000();
            c.starta();
            c.stoppa();
            c.betala((int)Math.Round(price * 100));

        }
    }
}
