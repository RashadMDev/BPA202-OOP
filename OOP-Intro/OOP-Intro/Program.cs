#region Notes
/*
Inheritance
Diamond Problem
Base (Super) Class (base keyword)
CTOR calling itself (this keyword)
*/
#endregion
namespace OOP_Intro;

class Program
{
    public static void Main()
    {

        #region Object Initializers
        // BankCustomer customer = new BankCustomer
        // {
        //     Name = "Rashad",
        //     Surname = "Mammadov",
        //     Age = 25,
        //     FinCode = "RM1234567",
        //     IsMarried = true,
        //     Salary = 1600.00f,
        //     Pin = 1234,
        //     CurrentBalance = 3000.00f,
        //     Gender = "Male",
        //     PhoneNumber = "+994501234567",
        //     Address = "Baku, Azerbaijan",
        //     CardNumber = "1234567890123456"
        // };

        // BankCustomer anotherCustomer = new BankCustomer
        // {
        //     Name = "Rashad",
        //     Surname = "Mammadov",
        //     Age = 25,
        //     FinCode = "RM1234567",
        //     IsMarried = true,
        //     Salary = 1600.00f,
        //     Pin = 1234,
        //     CurrentBalance = 3000.00f,
        //     Gender = "Male",
        //     PhoneNumber = "+994501234567",
        //     Address = "Baku, Azerbaijan",
        //     CardNumber = "1234567890123456"
        // };
        #endregion

        #region Manual
        // customer.Age = 26;

        // System.Console.WriteLine($"CustomerName: {customer.Name}");
        // System.Console.WriteLine($"CustomerSurname: {customer.Surname}");
        // System.Console.WriteLine($"CustomerAge: {customer.Age}");
        // System.Console.WriteLine($"CustomerIsMarried: {customer.IsMarried}");
        // System.Console.WriteLine($"CustomerCurrentBalance: {customer.CurrentBalance}");
        // System.Console.WriteLine($"CustomerPhoneNumber: {customer.PhoneNumber}");
        // System.Console.WriteLine($"CustomerGender: {customer.Gender}");
        // System.Console.WriteLine($"CustomerAddress: {customer.Address}");
        #endregion

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

        // while (true)
        // {
        //     Console.Write("Enter Your Pin to Change: ");
        //     int oldPin = Convert.ToInt32(Console.ReadLine());

        //     Console.Write("Enter New Pin: ");
        //     int newPin = Convert.ToInt32(Console.ReadLine());

        //     if (oldPin != customer.Pin)
        //     {
        //         Console.WriteLine("Incorrect Pin. Try again.\n");
        //         continue;
        //     }
        //     else if (oldPin == newPin)
        //     {
        //         Console.WriteLine("New pin cannot be same as old pin\n");
        //         continue;
        //     }

        //     customer.ChangePin(oldPin, newPin);
        //     break;
        // }

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

        #region Contstructor
        // Book book = new Book(
        //     "Republic",
        //     "Plato",
        //     300,
        //     -380,
        //     "Philosophy",
        //     "A philosophical dialogue concerning justice and the order and character of the just city-state and",
        //     9.99
        // );
        // book.GetInfo();
        #endregion

        #region Getter Setter Methods and Property calls
        // Car car = new Car();

        // Car car2 = new Car("BMW", "X5", 2022, "Black", 4000, 65999.99);

        // car2.WheelCount = 4;
        // System.Console.WriteLine(car2.WheelCount);
        // System.Console.WriteLine(car2.Price);
        // System.Console.WriteLine(car2.Type);
        // car2.Type = "Sedan";
        // System.Console.WriteLine(car2.Price);
        #endregion

        #region Inheritance, this and base keywords
        // Student student = new Student("S001", 3.75f, "Rashad", "Mammadov", 25, "P001", 2025, 2025, false);
        // System.Console.WriteLine($"Student Name: {student.Name}");
        // System.Console.WriteLine($"Student Surname: {student.Surname}");
        // System.Console.WriteLine($"Student Age: {student.Age}");
        // System.Console.WriteLine($"Student Id: {student.StudentId}");
        // System.Console.WriteLine($"Student GPA: {student.GPA}");
        // System.Console.WriteLine($"Student Base Id: {student.Id}");
        // System.Console.WriteLine($"Student Created At: {student.CreatedAt}");
        // System.Console.WriteLine($"Student Updated At: {student.UpdatedAt}");
        // System.Console.WriteLine($"Student Is Deleted: {student.IsDeleted}");

        // Person person = new Person();
        #endregion
    }
}