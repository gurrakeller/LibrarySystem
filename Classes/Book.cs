namespace Librarysystem.Classes;

public class Book
{
    public Dictionary<string, string> Books { get; private set; }
    public Dictionary<string, string> BorrowedBooks { get; private set; }

    public Book()
    {
        
        Books = new Dictionary<string, string>
        {
            { "Moby Dick", ""},
            { "1984", ""},
            { "Sagan om ringen", ""},
            { "Harry Potter och De Vises Sten", ""},
            { "Brott och straff", ""},
            { "Stolthet och fördom", ""},
            { "Hungerspelen", ""},
            { "Da Vinci-koden", ""},
            { "Den gamle och havet", ""},
            { "Anne Franks dagbok", ""}
        };

        BorrowedBooks = new Dictionary<string, string> { };

    }
    
    
}