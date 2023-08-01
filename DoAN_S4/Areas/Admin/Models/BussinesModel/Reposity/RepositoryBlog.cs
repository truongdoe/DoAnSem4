using DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository;
using DoAN_S4.Models.DataModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Areas.Admin.Models.BussinesModel.Reposity
{
    public class RepositoryBlog : IRepositoryBlog
    {
        DbConText db;
        public RepositoryBlog(DbConText db)
        {
            this.db = db;
        }
        public bool Delete(string key)
        {
            try
            {
                db.blogs.DeleteOne(x => x._id == key);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Blog> getAll()
        {
            var blogCollecion = db.blogs;
            var blog = blogCollecion.Find(FilterDefinition<Blog>.Empty).ToList();
            return blog;
        }

        public Blog GetByID(string key)
        {
            return db.blogs.Find(x => x._id == key).FirstOrDefault();
        }

        public bool Insert(Blog entity)
        {
            db.blogs.InsertOne(entity);
            return true;
        }

        public List<Blog> Paging(int page, int pagesize, out long totalpages)
        {
            int skip = pagesize * (page - 1);
            long rows = db.blogs.CountDocuments(FilterDefinition<Blog>.Empty);
            totalpages = rows % pagesize == 0 ? rows / pagesize : (rows / pagesize) + 1;
            return db.blogs.Find(FilterDefinition<Blog>.Empty).Skip(skip).Limit(pagesize).ToList();
        }

        public bool Update(Blog entity)
        {
            var b = Builders<Blog>.Update.Set("Content", entity.Content)
                  .Set("Image", entity.Image)
                  .Set("Status", entity.Status);
            db.blogs.UpdateOne(MongoX509Identity => MongoX509Identity._id == entity._id, b);
            return true;
        }
    }
}
