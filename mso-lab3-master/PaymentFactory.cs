using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class PaymentFactory
    {
        PaymentMethod payment;

        public void selectPaymentMethod(UIPayment uiPayment, float price)
        {

            switch (uiPayment)
            {
                case UIPayment.CreditCard:
                    payment = new CreditCard();
                    payment.HandlePayment(price);
                    break;
                case UIPayment.DebitCard:
                    payment = new DebitCard();
                    payment.HandlePayment(price);
                    break;
                case UIPayment.Chipknip:
                    payment = new Chipknip();
                    payment.HandlePayment(price);
                    break;

            }
        }
    }
}
