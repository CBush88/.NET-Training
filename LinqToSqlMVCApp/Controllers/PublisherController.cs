using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqToSqlMVCApp.Models;

namespace LinqToSqlMVCApp.Controllers
{
    public class PublisherController : Controller
    {
        private OperationDataContext context;
        public PublisherController()
        {
            context = new OperationDataContext();
        }
        // GET: Publisher
        public ActionResult Index()
        {
            IList<PublisherModel> publisherList = new List<PublisherModel>();
            var query = from publisher in context.Publishers
                        select publisher;
            var publishers = query.ToList();
            foreach(var publisherData in publishers)
            {
                publisherList.Add(new PublisherModel()
                {
                    Id = publisherData.Id,
                    Name = publisherData.Name,
                    Year = int.Parse(publisherData.Year)
                });
            }
            return View(publisherList);
        }

        public ActionResult Create()
        {
            PublisherModel model = new PublisherModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(PublisherModel model)
        {
            try
            {
                Publisher publisher = new Publisher()
                {
                    Name = model.Name,
                    Year = model.Year.ToString()
                };
                context.Publishers.InsertOnSubmit(publisher);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Edit(int Id)
        {
            PublisherModel model = context.Publishers.Where(x => x.Id == Id).Select(x => new PublisherModel()
            {
                Name = x.Name,
                Year = int.Parse(x.Year)
            }).SingleOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(PublisherModel model)
        {
            try
            {
                Publisher publisher = context.Publishers.Where(x => x.Id == model.Id).Single<Publisher>();
                publisher.Id= model.Id;
                publisher.Name=model.Name;
                publisher.Year = model.Year.ToString();
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch 
            {
                return View(model); 
            }
        }
        public ActionResult Details(int Id)
        {
            PublisherModel model = context.Publishers.Where(x => x.Id == Id).Select(x => new PublisherModel()
            {
                Id = x.Id,
                Name = x.Name,
                Year = int.Parse(x.Year)
            }).SingleOrDefault();
            return View(model);
        }

        public ActionResult Delete(int Id)
        {
            PublisherModel model = context.Publishers.Where(x => x.Id == Id).Select(x => new PublisherModel()
            {
                Id = x.Id,
                Name = x.Name,
                Year = int.Parse(x.Year)
            }).SingleOrDefault();
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(PublisherModel model)
        {
            try
            {
                Publisher publisher = context.Publishers.Where(x => x.Id == model.Id).Single<Publisher>();
                context.Publishers.DeleteOnSubmit(publisher);
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