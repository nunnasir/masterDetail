using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLayoutHtmlHelper.Models;
using MvcLayoutHtmlHelper.Models.Context;

namespace MvcLayoutHtmlHelper.Controllers
{
    public class PurchasesController : Controller
    {

        ProjectDbContext _db = new ProjectDbContext();

        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Purchase purchase)
        {

            if (ModelState.IsValid && purchase.PurchaseDetailses != null && purchase.PurchaseDetailses.Count > 0)
            {
                _db.Purchases.Add(purchase);
                var isAdded = _db.SaveChanges() > 0;
                if (isAdded)
                {
                    //var inPurchase = _db.Purchases.Where(c => c.Id == purchase.Id).FirstOrDefault();
                    //purchase.PurchaseDetailses = inPurchase.PurchaseDetailses;
                    return View(purchase);
                }
            }
            return View();

        }



    }
}