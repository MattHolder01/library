using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("1984", "George Orwell", 1);
        Book book2 = new Book("Brave New World", "Aldous Huxley", 2);
        Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 3);
        Book book4 = new Book("The Green Mile", "Stephen King", 4); 

        library.collection[0] = book1;
        library.collection[1] = book2;
        Console.WriteLine(library.collection);
    }
}
