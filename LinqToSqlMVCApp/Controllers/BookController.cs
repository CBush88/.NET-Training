using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqToSqlMVCApp.Models;


namespace LinqToSqlMVCApp.Controllers
{
    public class BookController : Controller
    {
        private OperationDataContext context;
        // GET: Book
        public BookController()
        {
            context = new OperationDataContext();
        }
        private void PreparePublisher(BookModel model)
        {
            model.Publishers = context.Publishers.AsQueryable<Publisher>().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }
        public ActionResult Index()
        {
            IList<BookModel> BookList = new List<BookModel>();
            var query = from book in context.Books
                        join Publisher in context.Publishers
                        on book.PublisherId equals Publisher.Id
                        select new BookModel
                        {
                            Id = book.Id,
                            Title = book.Title,
                            PublisherName = Publisher.Name,
                            Author = book.Author,
                            Year = book.Year,
                            Price = book.Price
                        };
            BookList = query.ToList();
            return View(BookList);
        }

        public ActionResult Details(int id)
        {
            BookModel model = context.Books.Where(x => x.Id == id).Select(x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Year = x.Year,
                Price = x.Price,
                PublisherId = x.Publisher.Id,
                PublisherName = x.Publisher.Name
            }).SingleOrDefault();

            return View(model);
        }

        public ActionResult Create()
        {
            BookModel model = new BookModel();
            PreparePublisher(model);
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(BookModel model)
        {
            try
            {
                Book book = new Book()
                {
                    Title = model.Title,
                    Author = model.Author,
                    Year = model.Year,
                    Price = model.Price,
                    PublisherId = model.PublisherId
                };
                context.Books.InsertOnSubmit(book);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            BookModel model = context.Books.Where(x => x.Id == id).Select(x => 
            new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Year = x.Year,
                Price = x.Price,
                PublisherId = x.Publisher.Id
            }).SingleOrDefault();
            PreparePublisher(model);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(BookModel model)
        {
            try
            {
                Book book = context.Books.Where(x => x.Id == model.Id).Single<Book>();
                book.Title= model.Title;
                book.Author= model.Author;
                book.Year= model.Year;
                book.Price= model.Price;
                book.PublisherId= model.PublisherId;
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
        
        public ActionResult Delete(int id)
        {
            BookModel model = context.Books.Where(x => x.Id == id).Select(x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author,
                Year = x.Year,
                Price = x.Price,
                PublisherName = x.Publisher.Name
            }).SingleOrDefault();
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(BookModel model)
        {
            try
            {
                Book book = context.Books.Where(x => x.Id == model.Id).Single<Book>();
                context.Books.DeleteOnSubmit(book);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}