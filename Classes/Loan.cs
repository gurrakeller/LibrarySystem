namespace Librarysystem.Classes;

public class Loan
{
    public User LoanUserInfo { get; set; }
    public Book BookInfo { get; set; }

    public Loan(User loanUserInfo, Book bookInfo)
    {
        LoanUserInfo = loanUserInfo;
        BookInfo = bookInfo;
    }

    Loan loanBook()
    {
        return new Loan(LoanUserInfo, BookInfo);
    }
}