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
    public class AppTokenInfoesController : Controller
    {
        private Db db = new Db();

        // GET: AppTokenInfoes
        public ActionResult Index()
        {
            return View(db.AppTokenInfo.ToList());
        }

        // GET: AppTokenInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppTokenInfo appTokenInfo = db.AppTokenInfo.Find(id);
            if (appTokenInfo == null)
            {
                return HttpNotFound();
            }
            return View(appTokenInfo);
        }

        // GET: AppTokenInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppTokenInfoes/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AppTitle,appID,appsecret")] AppTokenInfo appTokenInfo)
        {
            if (ModelState.IsValid)
            {
                db.AppTokenInfo.Add(appTokenInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appTokenInfo);
        }

        // GET: AppTokenInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppTokenInfo appTokenInfo = db.AppTokenInfo.Find(id);
            if (appTokenInfo == null)
            {
                return HttpNotFound();
            }
            return View(appTokenInfo);
        }

        // POST: AppTokenInfoes/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AppTitle,appID,appsecret")] AppTokenInfo appTokenInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appTokenInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appTokenInfo);
        }

        // GET: AppTokenInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppTokenInfo appTokenInfo = db.AppTokenInfo.Find(id);
            if (appTokenInfo == null)
            {
                return HttpNotFound();
            }
            return View(appTokenInfo);
        }

        // POST: AppTokenInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppTokenInfo appTokenInfo = db.AppTokenInfo.Find(id);
            db.AppTokenInfo.Remove(appTokenInfo);
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
