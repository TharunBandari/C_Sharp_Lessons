using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SayHello(String name)
        {
            if (String.IsNullOrEmpty(name))
                ViewData["v1"] = "Name is Empty";
            else
                ViewData["v1"] = name;
            return View();
        }

        public IActionResult DoLogin(String txtUser, String txtpwd)
        {
            ViewData[" userValue"] = $"{txtUser}, {txtpwd}";
            return View();
        }

        public IActionResult AddNewBook(Book pbook)
        {
            Book book = new Book();
            return View(book);
        }

        public IActionResult SaveNewBook(Book pBook)
        {
            String fName = @"c:\temp\Book.csv";
            string strBook = $"{pBook.BookID} , {pBook.Title} , {pBook.AuthorName} , {pBook.Cost}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strBook + Environment.NewLine);
            }
            return View(pBook);
        }

        public IActionResult ListAllBook()
        {
            string fName = @"c:\temp\Book.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(",");
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }
                return View(list);
            }
        }

        private Book StringToBook(string[] data, Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }

        public IActionResult AddNewAuthor()
        {
            Author author = new Author();



            return View(author);
        }



        public IActionResult SaveNewAuthor(Author pAuthor)
        {
            String fName = @"c:\cemp\author.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName}, {pAuthor.NoOfBooksPublished}, {pAuthor.AuthorDateOfBirth},{pAuthor.RoyalityCompany}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor + Environment.NewLine);
            }
            return View(pAuthor);
        }
        public IActionResult ListAllAuthors()
        {



            string fName = @"c:\cemp\Author.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {



                string strAuthor = $"{sr.ReadLine()}";
                String[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(",");
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }
                return View(list);
            }
        }



        private Author StringToAuthor(string[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.NoOfBooksPublished = int.Parse(data[2]);
            author.AuthorDateOfBirth = int.Parse(data[3]);
            author.RoyalityCompany = data[4];
            return author;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}