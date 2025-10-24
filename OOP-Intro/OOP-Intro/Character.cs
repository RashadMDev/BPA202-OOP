namespace OOP_Intro;


public abstract class Character
{
      public string Name { get; set; }
      public int Health { get; set; }
      public int Level { get; set; }

      public abstract void Attack();
      public abstract void Defend();
      public void ShowStats()
      {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Level: {Level}");
      }
}

public class Warrior : Character
{
      public override void Attack()
      {
            System.Console.WriteLine($"{Name} swings a sword!");
      }
      public override void Defend()
      {
            System.Console.WriteLine($"{Name} raises a shield!");
      }
}

public class Mage : Character
{
      public override void Attack()
      {
            System.Console.WriteLine($"{Name} casts a fireball!");
      }
      public override void Defend()
      {
            System.Console.WriteLine($"{Name} conjures a magical barrier!");
      }
}

public class Archer : Character
{
      public override void Attack()
      {
            System.Console.WriteLine($"{Name} shoots an arrow!");
      }
      public override void Defend()
      {
            System.Console.WriteLine($"{Name} dodges the attack!");
      }
}

