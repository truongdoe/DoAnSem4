using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoAN_S4.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        IRepositoryAccount repositoryAccount;
        public AccountController (IRepositoryAccount repositoryAccount)
        {
            this.repositoryAccount = repositoryAccount;
        }

        // GET: Account
        public ActionResult Index(string email, int page = 1)
        {
            page = page < 1 ? 1 : page;
            if (string.IsNullOrEmpty(email))
            {
                long totalpage;
                var data = repositoryAccount.Paging(page, 5, out totalpage);
                ViewBag.totalpage = totalpage;
                ViewBag.page = page;
                return View(data);
            }
            else
            {
                long totalpage;
                var data = repositoryAccount.SearchPaging(email, page, 5, out totalpage);
                ViewBag.totalpage = totalpage;
                ViewBag.page = page;
                ViewBag.email = email;
                return View(data);
            }
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
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

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}