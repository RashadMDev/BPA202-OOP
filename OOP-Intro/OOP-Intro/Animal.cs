namespace OOP_Intro;


public class Animal
{
      public string Name { get; set; }

      public virtual void Speak()
      {
            Console.WriteLine("The animal makes a sound.");
      }
}

public class Dog : Animal
{
      public override void Speak()
      {
            base.Speak();
            Console.WriteLine("Woof! Woof!");
      }
}

public class Cat : Dog
{
      public override void Speak()
      {
            base.Speak();
            Console.WriteLine("Meow! Meow!");
      }
}


