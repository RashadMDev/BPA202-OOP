#region Notes
/*
var, anonymous objects
object initializers
classes
*/
#endregion


namespace OOP_Intro;

class Program

{
    public static void Main()
    {

        #region Object Initializers
        BankCustomer customer = new BankCustomer
        {
            Name = "Rashad",
            Surname = "Mammadov",
            Age = 25,
            FinCode = "RM1234567",
            IsMarried = true,
            Salary = 1600.00f,
            Pin = 1234,
            CurrentBalance = 3000.00f,
            Gender = "Male",
            PhoneNumber = "+994501234567",
            Address = "Baku, Azerbaijan",
            CardNumber = "1234567890123456"
        };

        BankCustomer anotherCustomer = new BankCustomer
        {
            Name = "Rashad",
            Surname = "Mammadov",
            Age = 25,
            FinCode = "RM1234567",
            IsMarried = true,
            Salary = 1600.00f,
            Pin = 1234,
            CurrentBalance = 3000.00f,
            Gender = "Male",
            PhoneNumber = "+994501234567",
            Address = "Baku, Azerbaijan",
            CardNumber = "1234567890123456"
        };
        #endregion

        // customer.Age = 26;

        // System.Console.WriteLine($"CustomerName: {customer.Name}");
        // System.Console.WriteLine($"CustomerSurname: {customer.Surname}");
        // System.Console.WriteLine($"CustomerAge: {customer.Age}");
        // System.Console.WriteLine($"CustomerIsMarried: {customer.IsMarried}");
        // System.Console.WriteLine($"CustomerCurrentBalance: {customer.CurrentBalance}");
        // System.Console.WriteLine($"CustomerPhoneNumber: {customer.PhoneNumber}");
        // System.Console.WriteLine($"CustomerGender: {customer.Gender}");
        // System.Console.WriteLine($"CustomerAddress: {customer.Address}");

        #region Method Calls
        // Console.Write("Enter your pin: ");
        // int pin = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter amount to withdraw: ");
        // double amountToWithdraw = Convert.ToDouble(Console.ReadLine());
        // customer.WithdrawMoney(amountToWithdraw, pin);

        // Console.Write("Enter your card number: ");
        // string cardNumber = Console.ReadLine();
        // Console.Write("Insert: ");
        // double amountToDeposit = Convert.ToDouble(Console.ReadLine());
        // customer.DepositMoney(amountToDeposit, cardNumber);

        System.Console.WriteLine("Enter Your Pin to Change: ");
        int oldPin = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter New Pin: ");
        int newPin = Convert.ToInt32(Console.ReadLine());
        customer.ChangePin(oldPin, newPin);
        #endregion


        #region Manual Data Set
        // string name = "Rashad";
        // string surname = "Mammadov";
        // byte age = 24;
        // string finCode = "RM1234567";
        // bool isMarried = false;
        // float salary = 1500.50f;
        // int pin = 1234;
        // double currentBalance = 2500.75;
        // string gender = "Male";
        // string phoneNumber = "+994501234567";
        // string address = "Baku, Azerbaijan";
        #endregion

        #region Anonymous Object, var keyword
        // var customer = new
        // {
        //     Name = "Rashad",
        //     Surname = "Mammadov",
        //     Age = 24,
        //     FinCode = "RM1234567",
        //     IsMarried = false,
        //     Salary = 1500.50f,
        //     Pin = 1234,
        //     CurrentBalance = 2500.75f,
        //     Gender = "Male",
        //     PhoneNumber = "+994501234567",
        //     Address = "Baku, Azerbaijan"
        // };
        #endregion

    }
}

