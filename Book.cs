using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2_b_
{
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(int bookID, string title, string author)
        {
            BookID = bookID;
            Title = title;
            Author = author;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"BookID: {BookID}, Title: {Title}, Author: {Author}, Available: {IsAvailable}");
        }
    }

    internal class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; private set; } = new List<Book>();

        public Member(int memberID, string name)
        {
            MemberID = memberID;
            Name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"MemberID: {MemberID}, Name: {Name}, Borrowed Books: {BorrowedBooks.Count}");
        }
    }

    internal class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void RegisterMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member '{member.Name}' registered successfully.");
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to library.");
        }

        public void LendBook(int bookID, int memberID)
        {
            Book book = books.Find(b => b.BookID == bookID && b.IsAvailable);
            Member member = members.Find(m => m.MemberID == memberID);

            if (book != null && member != null)
            {
                book.IsAvailable = false;
                member.BorrowedBooks.Add(book);
                Console.WriteLine($"Book '{book.Title}' lent to member '{member.Name}'.");
            }
            else
            {
                Console.WriteLine("Book not available or member not found.");
            }
        }

        public void ShowAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            foreach (var book in books)
            {
                if (book.IsAvailable)
                    book.DisplayInfo();
            }
        }
    }

}
