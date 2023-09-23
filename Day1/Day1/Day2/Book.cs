using ProjectOne.Day2;

namespace ProjectOne.Day2
{
    internal class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string BookAuthorName { get; set; } = string.Empty;
        public int BookNumber { get; set; }
        public string BookDescription { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"BookId:{BookId},BookName:{this.BookName},{BookDescription},\n" +
               $" BookDescription:{BookDescription},Book Number:{BookNumber},Book Author Name:{BookAuthorName}";
        }
    }
}
internal class TestBook
{
    public static void Books()
    {
        Book Book1 = new Book();
        Book1.BookId = 1;
        Book1.BookName = "Random Things";
        Book1.BookAuthorName = "Tharun";
        Book1.BookNumber = 1234;
        Book1.BookDescription = "Hello World";
        string value = Book1.ToString();
        Console.WriteLine(value);

    }
}