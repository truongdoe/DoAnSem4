using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository;
using DoAN_S4.Models.DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoAN_S4.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        IRepositoryContact repositoryContact;
        public ContactController(IRepositoryContact repositoryContact)
        {
            this.repositoryContact = repositoryContact;
        }
        // GET: Contact
        public ActionResult Index()
        {
            var data = repositoryContact.getAll();

            return View(data);
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(string id)
        {
            var c = repositoryContact.GetByID(id);
            return View(c);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contact contact, IFormCollection collection)
        {
            
                repositoryContact.Update(contact);

                return RedirectToAction(nameof(Index));
            
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(string id)
        {
            repositoryContact.Delete(id);
            return RedirectToAction(nameof(Index));
        }

       
    }
}