using System;
using System.Windows.Forms;

namespace Lab3
{
	public interface ICard
	{
		void Connect();
		void Disconnect();
		int BeginTransaction(float amount);
		bool EndTransaction(int id);
		void CancelTransaction(int id);
	}

    public abstract class Card : Payment, ICard
     {
        public abstract void Connect();
        public abstract void Disconnect();
        public abstract int BeginTransaction(float amount);
        public abstract bool EndTransaction(int id);
        public abstract void CancelTransaction(int id);
        public override bool HandlePayment(float price)
        {
            return true;
        }
        public bool isSuccessful(int id)
        {
            if (!EndTransaction(id))
            {
                return false;
            }
            return true;
        }
       
    }

	// Mock CreditCard implementation
	public class CreditCard : Card
	{
        public override bool HandlePayment(float amount)
        {
            Connect();
            int id = BeginTransaction(amount);
            return isSuccessful(id);
        }

		public override void Connect ()
		{
			MessageBox.Show ("Connecting to credit card reader");
		}

        public override void Disconnect()
		{
			MessageBox.Show ("Disconnecting from credit card reader");
		}

        public override int BeginTransaction(float amount)
		{
			MessageBox.Show ("Begin transaction 1 of " + amount + " EUR");
			return 1;
		}

        public override bool EndTransaction(int id)
		{
			if (id != 1)
				return false;

			MessageBox.Show("End transaction 1");
			return true;
		}

        public override void CancelTransaction(int id)
		{
			if (id != 1)
				throw new Exception ("Incorrect transaction id");

			MessageBox.Show("Cancel transaction 1");
		}

	}

    // Mock CreditCard implementation
    public class DebitCard : Card
    {
        public override bool HandlePayment(float amount)
        {
            Connect();
            int id = BeginTransaction(amount);
            return isSuccessful(id);
        }

        public override void Connect()
        {
            MessageBox.Show ("Connecting to debit card reader");
        }

        public override void Disconnect()
        {
            MessageBox.Show ("Disconnecting from debit card reader");
        }

        public override int BeginTransaction(float amount)
        {
            MessageBox.Show ("Begin transaction 1 of " + amount + " EUR");
            return 1;
        }

        public override bool EndTransaction(int id)
        {
            if (id != 1)
                return false;

            MessageBox.Show("End transaction 1");
            return true;
        }

        public override void CancelTransaction(int id)
        {
            if (id != 1)
                throw new Exception ("Incorrect transaction id");

            MessageBox.Show("Cancel transaction 1");
        }
    }

     //Mock Chipknip implementation
    public class Chipknip : Card
    {
        
        public override bool HandlePayment(float amount)
        {
            Connect();
            int id = BeginTransaction(amount);
            return isSuccessful(id);
        }

        public override void Connect()
        {
            MessageBox.Show("Connecting to chipknip reader");
        }

        public override void Disconnect()
        {
            MessageBox.Show("Disconnecting from chipknip reader");
        }

        public override int BeginTransaction(float amount)
        {
            MessageBox.Show("Begin transaction 1 of " + amount + " EUR");
            return 1;
        }

        public override bool EndTransaction(int id)
        {
            if (id != 1)
                return false;

            MessageBox.Show("End transaction 1");
            return true;
        }

        public override void CancelTransaction(int id)
        {
            if (id != 1)
                throw new Exception("Incorrect transaction id");

            MessageBox.Show("Cancel transaction 1");
        }
    }
}

