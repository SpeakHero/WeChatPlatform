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
    public class AppInterfaceInfoesController : Controller
    {
        private Db db = new Db();

        // GET: AppInterfaceInfoes
        public ActionResult Index()
        {
            var appInterfaceInfo = db.AppInterfaceInfo.Include(a => a.AppTokenInfo);
            return View(appInterfaceInfo.ToList());
        }

        // GET: AppInterfaceInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppInterfaceInfo appInterfaceInfo = db.AppInterfaceInfo.Find(id);
            if (appInterfaceInfo == null)
            {
                return HttpNotFound();
            }
            return View(appInterfaceInfo);
        }

        // GET: AppInterfaceInfoes/Create
        public ActionResult Create()
        {
            ViewBag.AppTokenId = new SelectList(db.AppTokenInfo, "Id", "AppTitle");
            return View();
        }

        // POST: AppInterfaceInfoes/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,URL,Token,AppTokenId,JSDomain")] AppInterfaceInfo appInterfaceInfo)
        {
            if (ModelState.IsValid)
            {
                db.AppInterfaceInfo.Add(appInterfaceInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AppTokenId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", appInterfaceInfo.AppTokenId);
            return View(appInterfaceInfo);
        }

        // GET: AppInterfaceInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppInterfaceInfo appInterfaceInfo = db.AppInterfaceInfo.Find(id);
            if (appInterfaceInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.AppTokenId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", appInterfaceInfo.AppTokenId);
            return View(appInterfaceInfo);
        }

        // POST: AppInterfaceInfoes/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,URL,Token,AppTokenId,JSDomain")] AppInterfaceInfo appInterfaceInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appInterfaceInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AppTokenId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", appInterfaceInfo.AppTokenId);
            return View(appInterfaceInfo);
        }

        // GET: AppInterfaceInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppInterfaceInfo appInterfaceInfo = db.AppInterfaceInfo.Find(id);
            if (appInterfaceInfo == null)
            {
                return HttpNotFound();
            }
            return View(appInterfaceInfo);
        }

        // POST: AppInterfaceInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppInterfaceInfo appInterfaceInfo = db.AppInterfaceInfo.Find(id);
            db.AppInterfaceInfo.Remove(appInterfaceInfo);
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
