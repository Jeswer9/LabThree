using System;

namespace Lab3
{
	public enum UIClass
	{
		FirstClass,
		SecondClass
	}

	public enum UIWay
	{
		OneWay,
		Return
	}

	public enum UIDiscount
	{
		NoDiscount,
		TwentyDiscount,
		FortyDiscount
	}

	public enum UIPayment
	{
		DebitCard,
		CreditCard,
        Chipknip,
        Cash
	}

	public struct UIInfo
	{
		string from, to;
		UIClass cls;
		UIWay way;
		UIDiscount discount;
		UIPayment payment;    

		public UIInfo (string from, string to, UIClass cls, UIWay way, UIDiscount discount, UIPayment payment)
		{
            
			this.from = from;
			this.to = to;
			this.cls = cls;
			this.way = way;
			this.discount = discount;
			this.payment = payment;
		}

        public float Price
        {
            get
            {
                return CalculatePrice();
            }
        }

		public string From {
			get {
				return from;
			}
		}

		public string To {
			get {
				return to;
			}
		}

		public UIClass Class {
			get {
				return cls;
			}
		}

		public UIWay Way {
			get {
				return way;
			}
		}

		public UIDiscount Discount {
			get {
				return discount;
			}
		}

		public UIPayment Payment {
			get {
				return payment;
			}
		}

        //Selects the tableColumn in the PriceTable
        private int SelectTableColumn()
        {
            // Compute the column in the table based on choices
            int tableColumn;
            // First based on class
            switch (Class)
            {
                case UIClass.FirstClass:
                    tableColumn = 3;
                    break;
                default:
                    tableColumn = 0;
                    break;
            }
            // Then, on the discount
            switch (Discount)
            {
                case UIDiscount.TwentyDiscount:
                    tableColumn += 1;
                    break;
                case UIDiscount.FortyDiscount:
                    tableColumn += 2;
                    break;
            }

            return tableColumn;
        }

        //Calculates the price of the Ticket
        private float CalculatePrice()
        {
            int tableColumn = SelectTableColumn();

            // Get number of tariefeenheden
            int tariefeenheden = Tariefeenheden.getTariefeenheden(From, To);

            // Get price
            float price = PricingTable.getPrice(tariefeenheden, tableColumn);
            if (Way == UIWay.Return)
            {
                price *= 2;
            }
            // Add 50 cent if paying with credit card
            if (Payment == UIPayment.CreditCard)
            {
                price += 0.50f;
            }

            return price;
        }
	}
}

