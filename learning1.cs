using System;


public class Book
{
  public string title;
  public string author;
  public int ISBN;
  public bool isCheckedOut = false;

  public Book(string bookTitle, string bookAuthor, int bookISBN)
  {
    title = bookTitle;
    author = bookAuthor;
    ISBN = bookISBN;
  } 

  public void checkOut()
  {
    isCheckedOut = true;
  }
  public void returnBook()
  {
    isCheckedOut = false;
  }
}

public class Library
{
  public Book[] collection = new Book[10];
  public Library(){}
}

/*
public class Member
{
  public string name;
  public int memberId;
  public Book[] checkedOutBooks = new Book[10];
  public int checkedOutCount = 0;

  public virtual void checkOut(Book book)
  {
    int pos = -100;
    for (int i = 0; i < checkedOutBooks.Length; i++)
    {
      if (checkedOutBooks[i] == null)
      {
        pos = i;
      }
      else if (checkedOutBooks[i].title == book.title && checkedOutBooks[i].author == book.author)
      {
        Console.WriteLine("You cannot check out the same book twice.");
        return;
      }
    }
    if (pos == -100){
      Console.WriteLine("You cannot check out more than 10 books at a time.");
      return;
    }
    checkedOutBooks[pos] = book;
    book.isCheckedOut = true;
    checkedOutCount += 1;
  }

  public void returnBook(Book book)
  {
    for (int i = 0; i < checkedOutBooks.Length; i++)
    {
      if (checkedOutBooks[i].ISBN == book.ISBN)
      {
        checkedOutBooks[i] = null;
        book.isCheckedOut = false;
        checkedOutCount -= 1;
      }
    }
  }

  public string[] getCheckedOutBooks()
  {
    string[] books = new string[checkedOutCount];
    int pos = 0;
    foreach (Book book in checkedOutBooks)
    {
      if (book != null)
      {
        books[pos] = book;
        pos += 1;
      }
    }
    return books;
  }
}

public class Librarian : Member
{
  public int employeeId;

  public override void checkOut(Book book)
  {
    int pos = -100;
    for (int i = 0; i < checkedOutBooks.Length; i++)
    {
      if (checkedOutBooks[i] == null)
      {
        pos = i;
      }
    }
    if (pos == -100)
    {
      Console.WriteLine("You cannot check out more than 10 books at a time.");
      return;
    }
    checkedOutBooks[pos] = book;
    book.isCheckedOut = true;
    checkedOutCount += 1;
  }

  public void addBook(Book book, Library library)
  {
    for (int i = 0; i < library.collection.Length; i++)
    {
      if (library.collection[i] == null)
      {
        library.collection[i] = book;
        break;
      }
      // Add method to check if all 100 slots are taken?
    }
  }

  public void removeBook(Book book, Library library)
  {
    for (int i = 0; i < library.collection.Length; i++)
    {
      if (library.collection[i].ISBN == book.ISBN)
      {
        library.collection[i] = null;
      }
    }
  }
}

*/

