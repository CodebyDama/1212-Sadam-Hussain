using System;

class Book
{
    private string title;
    private string author;
    private string isbn;
    private double price;

    public Book(string title, string author, string isbn, double price)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
        this.price = price;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine("\nBook Details:");
        Console.WriteLine("----------------");
        Console.WriteLine("Title     : " + title);
        Console.WriteLine("Author    : " + author);
        Console.WriteLine("ISBN      : " + isbn);
        Console.WriteLine("Price (Rs): " + price);
    }

    public void ApplyDiscount(double percentage)
    {
        double discountAmount = price * percentage / 100;
        price -= discountAmount;
        Console.WriteLine("Discount Applied: Rs. " + discountAmount);
        Console.WriteLine("New Price after discount: Rs. " + price);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author name: ");
        string author = Console.ReadLine();

        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();

        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());

        Book book1 = new Book(title, author, isbn, price);
        book1.DisplayBookInfo();

        Console.Write("Enter discount percentage: ");
        double discount = double.Parse(Console.ReadLine());
        book1.ApplyDiscount(discount);
    }
}