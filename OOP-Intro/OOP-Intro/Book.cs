namespace OOP_Intro;

internal class Book
{
      public string title;
      public string author;
      public int pageCount;
      public int releaseDate;
      public string genre;
      public string description;
      public double price;

      public Book(string title, string author, int pageCount, int releaseDate, string genre, string description, double price)
      {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
            this.releaseDate = releaseDate;
            this.genre = genre;
            this.description = description;
            this.price = price;
      }

      public void GetInfo()
      {
            System.Console.WriteLine($"Title: {title}");
            System.Console.WriteLine($"Author: {author}");
            System.Console.WriteLine($"Page Count: {pageCount}");
            System.Console.WriteLine($"Release Date: {releaseDate}");
            System.Console.WriteLine($"Genre: {genre}");
            System.Console.WriteLine($"Description: {description}");
            System.Console.WriteLine($"Price: {price}");
      }
}