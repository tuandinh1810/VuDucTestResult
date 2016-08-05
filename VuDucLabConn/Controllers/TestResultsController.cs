using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VuDucLapConnModel;

namespace VuDucLabConn.Controllers
{
    public class TestResultsController : Controller
    {
        private VuDucResultTestEntities db = new VuDucResultTestEntities();

        // GET: TestResults
        public ActionResult Index()
        {
            return View(db.TestResults.ToList());
        }
        //GET: TestResult by Patient
        public ActionResult Patient(string sid)
        {
            Patient lstTestResult = db.Patients.Include("TestResults").Where(o => o.SID.Equals(sid)).FirstOrDefault();
            return View("Index", lstTestResult);
        }
        // GET: TestResults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestResult testResult = db.TestResults.Find(id);
            if (testResult == null)
            {
                return HttpNotFound();
            }
            return View(testResult);
        }

        // GET: TestResults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TestResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AutoID,SID,Testcode,Result,TestName,ResultTime,Unit,NormalRange,Category,UpdateTime")] TestResult testResult)
        {
            if (ModelState.IsValid)
            {
                db.TestResults.Add(testResult);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testResult);
        }

        // GET: TestResults/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestResult testResult = db.TestResults.Find(id);
            if (testResult == null)
            {
                return HttpNotFound();
            }
            return View(testResult);
        }

        // POST: TestResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AutoID,SID,Testcode,Result,TestName,ResultTime,Unit,NormalRange,Category,UpdateTime")] TestResult testResult)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testResult).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testResult);
        }

        // GET: TestResults/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestResult testResult = db.TestResults.Find(id);
            if (testResult == null)
            {
                return HttpNotFound();
            }
            return View(testResult);
        }

        // POST: TestResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TestResult testResult = db.TestResults.Find(id);
            db.TestResults.Remove(testResult);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
