using DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository;
using DoAN_S4.Models.DataModel;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Areas.Admin.Models.BussinesModel.Reposity
{
    public class RepositoryAccount : IRepositoryAccount
    {
        DbConText db;
        public RepositoryAccount (DbConText db)
        {
            this.db = db;
        }
        public bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Account> getAll()
        {
            return db.accounts.Find(FilterDefinition<Account>.Empty).ToList();
        }

        public Account GetByID(int key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Account entity)
        {
            throw new NotImplementedException();
        }

        public List<Account> Paging(int page, int pagesize, out long totalpage)
        {
            int skip = pagesize * (page - 1);
            long rows = db.accounts.CountDocuments(FilterDefinition<Account>.Empty);
            totalpage = rows % pagesize == 0 ? rows / pagesize : (rows / pagesize) + 1;
            return db.accounts.Find(FilterDefinition<Account>.Empty).Skip(skip).Limit(pagesize).ToList();
        }

        public List<Account> SearchPaging(string email, int page, int pagesize, out long totalpage)
        {
            int skip = pagesize * (page - 1);
            long rows = db.accounts.CountDocuments(x => x.Email.ToLower().Contains(email.ToLower()));
            totalpage = rows % pagesize == 0 ? rows / pagesize : (rows / pagesize) + 1;
            return db.accounts.Find(x => x.Email.ToLower().Contains(email.ToLower())).Skip(skip).Limit(pagesize).ToList();
        }

        public bool Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
