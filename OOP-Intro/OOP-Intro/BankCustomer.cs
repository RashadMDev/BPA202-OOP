

namespace OOP_Intro;
/*
Class members: fields, methods(if method is related to fields, static keyword is not used but if method is independent of fields static keyword is used)
Class default access modifier is internal
Class field's default access modifier is private
Class 

*/
class BankCustomer
{
      public string Name;
      public string Surname;
      public byte Age;
      public string FinCode;
      public bool IsMarried;
      public float Salary;
      public int Pin;
      public double CurrentBalance;
      public string Gender;
      public string PhoneNumber;
      public string Address;
      public string CardNumber;


      public void WithdrawMoney(double amount, int pin)
      {

            if (pin != Pin)
            {
                  Console.WriteLine("Incorrect PIN code!");
            }
            else if (amount > CurrentBalance)
            {
                  System.Console.WriteLine("Insufficient balance!");
            }
            else
            {
                  System.Console.WriteLine("Please take your money.");
                  CurrentBalance -= amount;
                  System.Console.WriteLine("Successfully Withdrawn!" + amount + "Your current balance is: " + CurrentBalance);
            }
      }

      public void DepositMoney(double amount, string cardNumber)
      {
            if (cardNumber != CardNumber)
            {
                  Console.WriteLine("Incorrect Card Number!");
            }
            else
            {
                  CurrentBalance += amount;
                  System.Console.WriteLine("Successfully Deposited!" + amount + "Your current balance is: " + CurrentBalance);
            }
      }

      public void ChangePin(int oldPin, int newPin)
      {
            if (oldPin != Pin)
            {
                  Console.WriteLine("Incorrect Pin");
            }
            else if (oldPin == newPin)
            {
                  Console.WriteLine("New pin cannot be same as old pin");
            }
            else
            {
                  Pin = newPin;
                  Console.WriteLine("Pin changed successfully");
            }
      }

}
