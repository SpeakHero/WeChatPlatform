using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CQCMXY.WeiXin.Data.Entity;
using CQCMXY.WeiXin.Data.Models;

namespace CQCMXY.WeiXin.WebServer.Controllers
{
    public class NewMsgsController : Controller
    {
        private Db db = new Db();

        // GET: NewMsgs
        public ActionResult Index()
        {
            var newMsgs = db.NewMsgs.Include(n => n.AppTokenInfo).Include(n => n.menus);
            return View(newMsgs.ToList());
        }

        // GET: NewMsgs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewMsgs newMsgs = db.NewMsgs.Find(id);
            if (newMsgs == null)
            {
                return HttpNotFound();
            }
            return View(newMsgs);
        }

        // GET: NewMsgs/Create
        public ActionResult Create()
        {
            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle");
            ViewBag.meunsId = new SelectList(db.menus, "Id", "pid");
            return View();
        }

        // POST: NewMsgs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AppTokenInfoId,Title,Contents,CreateTime,UpTime,Author,meunsId")] NewMsgs newMsgs)
        {
            if (ModelState.IsValid)
            {
                db.NewMsgs.Add(newMsgs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", newMsgs.AppTokenInfoId);
            ViewBag.meunsId = new SelectList(db.menus, "Id", "pid", newMsgs.meunsId);
            return View(newMsgs);
        }

        // GET: NewMsgs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewMsgs newMsgs = db.NewMsgs.Find(id);
            if (newMsgs == null)
            {
                return HttpNotFound();
            }
            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", newMsgs.AppTokenInfoId);
            ViewBag.meunsId = new SelectList(db.menus, "Id", "pid", newMsgs.meunsId);
            return View(newMsgs);
        }

        // POST: NewMsgs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AppTokenInfoId,Title,Contents,CreateTime,UpTime,Author,meunsId")] NewMsgs newMsgs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newMsgs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", newMsgs.AppTokenInfoId);
            ViewBag.meunsId = new SelectList(db.menus, "Id", "pid", newMsgs.meunsId);
            return View(newMsgs);
        }

        // GET: NewMsgs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewMsgs newMsgs = db.NewMsgs.Find(id);
            if (newMsgs == null)
            {
                return HttpNotFound();
            }
            return View(newMsgs);
        }

        // POST: NewMsgs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewMsgs newMsgs = db.NewMsgs.Find(id);
            db.NewMsgs.Remove(newMsgs);
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
