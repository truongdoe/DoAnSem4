using DoAN_S4.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository
{
    public interface IRepositoryContact:IRepositoryGeneric<Contact,string>
    {
        List<Contact> Paging(int page, int pagesize, out long totalpages);    
    }
}
