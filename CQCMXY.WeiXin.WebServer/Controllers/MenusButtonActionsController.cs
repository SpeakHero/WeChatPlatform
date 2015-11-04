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
    public class MenusButtonActionsController : Controller
    {
        private Db db = new Db();

        // GET: MenusButtonActions
        public ActionResult Index()
        {
            return View(db.MenusButtonAction.ToList());
        }

        // GET: MenusButtonActions/详细信息/5
        public ActionResult  Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenusButtonAction menusButtonAction = db.MenusButtonAction.Find(id);
            if (menusButtonAction == null)
            {
                return HttpNotFound();
            }
            return View(menusButtonAction);
        }

        // GET: MenusButtonActions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenusButtonActions/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Timestamp,ActionType,Actiondes,ActionDetails")] MenusButtonAction menusButtonAction)
        {
            if (ModelState.IsValid)
            {
                db.MenusButtonAction.Add(menusButtonAction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menusButtonAction);
        }

        // GET: MenusButtonActions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenusButtonAction menusButtonAction = db.MenusButtonAction.Find(id);
            if (menusButtonAction == null)
            {
                return HttpNotFound();
            }
            return View(menusButtonAction);
        }

        // POST: MenusButtonActions/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Timestamp,ActionType,Actiondes,ActionDetails")] MenusButtonAction menusButtonAction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menusButtonAction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menusButtonAction);
        }

        // GET: MenusButtonActions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenusButtonAction menusButtonAction = db.MenusButtonAction.Find(id);
            if (menusButtonAction == null)
            {
                return HttpNotFound();
            }
            return View(menusButtonAction);
        }

        // POST: MenusButtonActions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenusButtonAction menusButtonAction = db.MenusButtonAction.Find(id);
            db.MenusButtonAction.Remove(menusButtonAction);
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
