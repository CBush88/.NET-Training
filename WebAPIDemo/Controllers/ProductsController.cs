﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class ProductsController : ApiController
    {
        static readonly IProductRepository repository= new ProductRepository();
        
        public IEnumerable<Product> GetAllProducts()
        {
            return repository.GetAll();
        }

        public Product GetProduct(int id)
        {
            Product item = repository.Get(id);
            if(item == null)
            {
                throw new HttpResponseException (HttpStatusCode.NotFound);
            }
            return item;
        }

        public IEnumerable<Product> getProductsByCategory(string category)
        {
            return repository.GetAll().Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }

        //create
        public HttpResponseMessage PostProduct(Product item)
        {
            item = repository.Add(item);
            var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new {id = item.Id});
            response.Headers.Location = new Uri(uri);
            return response;
        }

        //update
        public void PutProduct(int id, Product item)
        {
            item.Id = id;
            if(!repository.Update(item))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        //delete
        public void DeleteProduct(int id)
        {
            Product item = repository.Get(id);
            if(item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Remove(id);
        }
    }
}
