namespace OOP_Intro;


public abstract class BaseEntity
{
      public string Id { get; set; }
      public int CreatedAt { get; set; }
      public int UpdatedAt { get; set; }
      public bool IsDeleted { get; set; }
      public BaseEntity()
      {

      }
      // public BaseEntity(string id, int createdAt, int updatedAt, bool isDeleted)
      // {
      //       Id = id;
      //       CreatedAt = createdAt;
      //       UpdatedAt = updatedAt;
      //       IsDeleted = isDeleted;
      //       System.Console.WriteLine("BaseEntity Constructor Called");
      // }

}

public class Person
{
      public string Name { get; set; }
      public string Surname { get; set; }
      public int Age { get; set; }


      public Person(string name, string surname, int age) : this(name, surname)
      {
            Age = age;
            Console.WriteLine("age");
      }

      public Person(string name, string surname) : this(name)
      {
            Surname = surname;
            Console.WriteLine("surname");
      }

      public Person(string name)
      {
            Name = name;
            Console.WriteLine("name");
      }

      public Person()
      {

      }

      // public Person()
      // {
      //       System.Console.WriteLine("Person Default Constructor Called");
      // }
      //
      // public Person(string name)
      // {
      //       Name = name;
      // }
      //
      // public Person(string name, string surname) : this(name)
      // {
      //       Surname = surname;
      // }
      //
      // public Person(string name, string surname, int age) : this(name, surname)
      // {
      //       Age = age;
      // }


      // public Person()
      // {

      // }
      // public Person(string name, string surname, int age, string id, int createdAt, int updatedAt, bool isDeleted)
      // : base(id, createdAt, updatedAt, isDeleted)
      // {
      //       Name = name;
      //       Surname = surname;
      //       Age = age;
      //       System.Console.WriteLine("Person Constructor Called");
      // }
}
// public class Student : Person
// {
//       public string StudentId { get; set; }
//       public float GPA { get; set; }

//       // public Student()
//       // {

//       // }
//       // public Student(string studentId, float gpa, string name, string surname, int age, string id, int createdAt, int updatedAt, bool isDeleted)
//       // : base(name, surname, age, id, createdAt, updatedAt, isDeleted)
//       // {
//       //       StudentId = studentId;
//       //       GPA = gpa;
//       //       System.Console.WriteLine("Student Constructor Called");
//       // }

// }

