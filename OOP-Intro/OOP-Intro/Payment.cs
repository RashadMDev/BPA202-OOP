namespace OOP_Intro;


public class Payment // Base class
{
      public virtual void Pay()
      {
            System.Console.WriteLine("Cash Payment processed.");
      }
}

public class CreditCardPayment : Payment // Derived class
{
      public override void Pay()
      {
            System.Console.WriteLine("Credit Card Payment processed.");
      }
}

public class PayPalPayment : Payment // Derived class
{
      public override void Pay()
      {
            System.Console.WriteLine("PayPal Payment processed.");
      }
}

public class PaypalDerived : PayPalPayment
{
      public override void Pay()
      {
            System.Console.WriteLine("Derived PayPal Payment processed.");
      }
}


public class PaymentProcessor
{
      //Paypal Payment
      public void MakePayment(PayPalPayment payment)
      {
            System.Console.WriteLine("Initiating payment...");
            payment.Pay();
      }
}