using Librarysystem.Classes;

namespace Librarysystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("please enter your email address:");
        string Email = Console.ReadLine();
        Console.WriteLine("please enter your adress:");
        string Adress = Console.ReadLine();
        Console.WriteLine("please enter your name:");
        string Name = Console.ReadLine();
        User user1 = new User(Name, Email, Adress);
        Console.Clear();
        
        //initial book library for the while true
        var library = new Book();
        
        while (true)
        { 
            Console.WriteLine("what would you like to do?\n1. Borrow a book\n2. Return a book\n3. Show available books");
            int answer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (answer == 1)
            {
                Console.WriteLine("What book would you like to borrow?");
                string borrowName = Console.ReadLine();
                
                if (library.BorrowedBooks.ContainsKey(borrowName))
                {
                    Console.WriteLine("This book is already borrowed.");
                    Thread.Sleep(1500);
                    Console.Clear();
                }

                else if (library.Books.ContainsKey(borrowName))
                {
                    Console.WriteLine("This book will be added to your borrowed books.");
                    library.BorrowedBooks.Add(borrowName, "");
                    Thread.Sleep(1500);
                    Console.Clear();
                }

                else
                {
                    Console.WriteLine("We unfortunately do not have this book in right now.");
                    Thread.Sleep(1500);
                    Console.Clear();
                }

            }
            
            else if (answer == 2)
            {
                Console.WriteLine("What book would you like to return?");
                string returnName = Console.ReadLine();
                if (library.BorrowedBooks.ContainsKey(returnName))
                {
                    library.BorrowedBooks.Remove(returnName);
                    Console.WriteLine("Book has been returned.");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("This  book doesn't exist or is not borrowed.");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
            }
            
            else if (answer == 3)
            {
                Console.WriteLine("Available books:\n");
                foreach (var book in library.Books)
                {
                    if (!library.BorrowedBooks.ContainsKey(book.Key))
                    {
                        Console.WriteLine($"{book.Key}");
                        
                    }
                }
            }
        }

    }
}