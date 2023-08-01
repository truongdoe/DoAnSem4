using DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository;
using DoAN_S4.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DoAN_S4.Areas.Admin.Models.BussinesModel.Reposity
{
    public class RepositoryContact : IRepositoryContact
    {
        DbConText db;
        public RepositoryContact(DbConText db)
        {
            this.db = db;
        }
        public bool Delete(string key)
        {
            try
            {
                db.contacts.DeleteOne(x => x._id == key);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Contact> getAll()
        {
            var ContactCollecion = db.contacts;
            var Contact = ContactCollecion.Find(FilterDefinition<Contact>.Empty).ToList();
            return Contact;
        }

        public Contact GetByID(string key)
        {
            return db.contacts.Find(x => x._id == key).FirstOrDefault();
        }

        public bool Insert(Contact entity)
        {
            db.contacts.InsertOne(entity);
            return true;
        }

        public List<Contact> Paging(int page, int pagesize, out long totalpages)
        {
            int skip = pagesize * (page - 1);
            long rows = db.contacts.CountDocuments(FilterDefinition<Contact>.Empty);
            totalpages = rows % pagesize == 0 ? rows / pagesize : (rows / pagesize) + 1;
            return db.contacts.Find(FilterDefinition<Contact>.Empty).Skip(skip).Limit(pagesize).ToList();
        }

        public bool Update(Contact entity)
        {
            var b = Builders<Contact>.Update.Set("Name", entity.Name)
                  .Set("Gmail", entity.Gmail)
                  .Set("Phone", entity.Phone)
                  .Set("Status", entity.Status);
            db.contacts.UpdateOne(x => x._id == entity._id, b);
            return true;
        }
    }
}
