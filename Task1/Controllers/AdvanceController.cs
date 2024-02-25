using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class AdvanceController : Controller
    {
        Task2Entities db = new Task2Entities();
        // GET: Advance
        public ActionResult Advance()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetBioId()
        {
            try
            {
                var employees = db.Masters.ToList();
                return Json(employees, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult GetEmpName(int BioId)
        {
            try
            {
                var empName = db.Masters.Where(m => m.BioId == BioId).Select(m => m.Name).FirstOrDefault();
                return Json(empName, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult GetBalance(int BioId)
        {
            try
            {
                var balance = db.Masters.Where(m => m.BioId == BioId).Select(m => m.Balance).FirstOrDefault();
                return Json(balance, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Save(Transaction Advance)
        {
            if (ModelState.IsValid)
            {
                db.Transactions.Add(Advance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                              .Select(e => e.ErrorMessage);
                return Json(new { success = false, errors = errors });
            }
        }

    }
}