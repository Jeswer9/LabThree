using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class PaymentFactory
    {
        Payment payment;

        public bool MakePayment(UIPayment uiPayment, float price)
        {

            switch (uiPayment)
            {
                case UIPayment.CreditCard:
                    payment = new CreditCard();
                    break;
                case UIPayment.DebitCard:
                    payment = new DebitCard();
                    break;
                case UIPayment.Chipknip:
                    payment = new Chipknip();
                    break;
                case UIPayment.Cash:
                    payment = new Cash();                    
                    break;
            }

            return payment.HandlePayment(price);
        }
    }
}
