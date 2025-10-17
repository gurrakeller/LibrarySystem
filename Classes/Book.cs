namespace Librarysystem.Classes;

public class Book
{
    public Dictionary<string, int> Books { get; private set; }
    public Dictionary<string, int> BorrowedBooks { get; private set; }

    public Book()
    {
        
        Books = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "Moby Dick", 2},
            { "1984", 4},
            { "Sagan om ringen", 1},
            { "Harry Potter och De Vises Sten", 5},
            { "Brott och straff", 4},
            { "Stolthet och fördom", 8},
            { "Hungerspelen", 1},
            { "Da Vinci-koden", 2},
            { "Den gamle och havet", 4},
            { "Anne Franks dagbok", 5}
        };

        BorrowedBooks = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

    }
    
    
}