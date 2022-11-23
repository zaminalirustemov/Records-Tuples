using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Id = 1;
            book1.Name = "Şeker Portakalı";
            book1.AuthorName = "Jose Mauro de Vasconcelos";
            book1.BookCode = book1.Name.Substring(0, 2).ToUpper() + Convert.ToString(1000 + book1.Id); 

            Book book2 = new Book();
            book2.Id = 2;
            book2.Name = "Ne İçin Varsan Onun İçin Yaşa";
            book2.AuthorName = "Hikmet Anıl Öztekin";
            book2.BookCode = book2.Name.Substring(0, 2).ToUpper() + Convert.ToString(1000 + book2.Id);


            Book book3 = new Book();
            book3.Id = 3;
            book3.Name = "Axın";
            book3.AuthorName = "Mihay Çiksentmihayi";
            book3.BookCode = book3.Name.Substring(0, 2).ToUpper() + Convert.ToString(1000 + book3.Id);

            Book book4 = new Book();
            book4.Id = 4;
            book4.Name = "Yaşamaq gözəl şeydir, qardaşım";
            book4.AuthorName = "Nazim Hikmet";
            book4.BookCode = book4.Name.Substring(0, 2).ToUpper() + Convert.ToString(1000 + book4.Id);

            Book book5 = new Book();
            book5.Id = 5;
            book5.Name = "Kozmos";
            book5.AuthorName = "Carl Sagan";
            book5.BookCode = book5.Name.Substring(0, 2).ToUpper() + Convert.ToString(1000 + book5.Id);


            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            Console.WriteLine("Books in the library:");
            foreach (Book book in library.ShowAllBook())
            {
                Console.WriteLine($"Name of book:    {book.Name}\nAuthor of book:  {book.AuthorName}\n--------------------------------------------------------");
            }
            Console.WriteLine("\nThe book with the ID you entered:");
            foreach (Book book in library.FindBookById(3))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Name of book:    {book.Name}\nAuthor of book:  {book.AuthorName}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nThe book with the code you entered:");
            foreach (Book book in library.FindBookByBookCode("KO1005"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Name of book:    {book.Name}\nAuthor of book:  {book.AuthorName}\n");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}