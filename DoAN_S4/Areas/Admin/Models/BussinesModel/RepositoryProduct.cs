using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAN_S4.Areas.Admin.Models.ViewModel;
using DoAN_S4.Models.DataModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DoAN_S4.Areas.Admin.Models.BussinesModel
{
    public class RepositoryProduct : IRepositoryProduct
    {
        DbConText db;
        public RepositoryProduct (DbConText db)
        {
            this.db = db;
        }
        
        public bool Delete(string key)
        {
            try
            {
                db.products.DeleteOne(x => x._id == key);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public List<Product> getAll()
        {
            return db.products.Find(FilterDefinition<Product>.Empty).ToList();
        }

        public Product GetByID(string key)
        {
            return db.products.Find(x => x._id == key).FirstOrDefault();
        }

        public List<productViewModel> getProductFull()
        {
            BsonDocument[] lookup = new BsonDocument[1]
           {
                new BsonDocument
                {
                    {
                        "$lookup",new BsonDocument
                        {
                            {"from","categories" },
                            {"localField","Id_Category" },
                            {"foreignField","_id" },
                            {"as","categories" }
                        }
                    }
                }

           };
            var products = db.products.Aggregate<BsonDocument>(lookup).ToList();
            var data = new List<productViewModel>();
            foreach (var e in products)
            {
                var p = new productViewModel();
                p._id = e["_id"].ToString();
                p.Name = e["Name"].ToString();
                p.Images = e["Images"].ToString();
                p.Quantity = e["Quantity"].ToInt32();
                p.NameCategory = e["categories"].AsBsonArray[1]["Name"].ToString();
                p.Price = e["Price"].ToInt32();
                p.Content = e["Content"].ToString();
                p.Status = e["Status"].ToInt32();
                data.Add(p);
            }
            return data;
        }

        public bool Insert(Product entity)
        {
            entity.Images = entity.Images ?? "";
            db.products.InsertOne(entity);
            return true;
        }

        public List<Product> Paging(int page, int pagesize, out long totalpage)
        {
            int skip = pagesize * (page - 1);
            long rows = db.products.CountDocuments(FilterDefinition<Product>.Empty);
            totalpage = rows % pagesize == 0 ? rows / pagesize : (rows / pagesize) + 1;
            return db.products.Find(FilterDefinition<Product>.Empty).Skip(skip).Limit(pagesize).ToList();
        }

        public List<Product> SearchPaging(string name, int page, int pagesize, out long totalpage)
        {
            int skip = pagesize * (page - 1);
            long rows = db.products.CountDocuments(x => x.Name.ToLower().Contains(name.ToLower()));
            totalpage = rows % pagesize == 0 ? rows / pagesize : (rows / pagesize) + 1;
            return db.products.Find(x => x.Name.ToLower().Contains(name.ToLower())).Skip(skip).Limit(pagesize).ToList();
        }

        public bool Update(Product entity)
        {
            var p = Builders<Product>.Update
               .Set("Name", entity.Name)
               .Set("Images", entity.Images)
               .Set("Quantity", entity.Quantity)
               .Set("Id_Category", entity.Id_Category)
               .Set("Price", entity.Price)
               .Set("Content", entity.Content)
               .Set("Status", entity.Status);
            db.products.UpdateOne(x => x._id == entity._id, p);
            return true;
        }
    }
}
