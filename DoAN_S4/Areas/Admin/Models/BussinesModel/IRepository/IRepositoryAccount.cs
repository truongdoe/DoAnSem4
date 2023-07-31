using DoAN_S4.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository
{
    public interface IRepositoryAccount : IRepositoryGeneric<Account, int>
    {
        List<Account> Paging(int page, int pagesize, out long totalpage);
        List<Account> SearchPaging(string email, int page, int pagesize, out long totalpage);
    }
}
