using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CQCMXY.WeiXin.Data.Entity;
using CQCMXY.WeiXin.Data.Models;

namespace CQCMXY.WeiXin.WebServer.Controllers
{
    public class menusController : BasesController
    {
        private Db db = new Db();

        // GET: menus
        public ActionResult Index()
        {
            var menus = db.menus.Include(m => m.AppTokenInfo).Include(m => m.MenusButtonActions).Where(d => d.Title != "根菜单");
            return View(menus.ToList());
        }

        // GET: menus/详细信息/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menus menus = db.menus.Find(id);
            if (menus == null)
            {
                return HttpNotFound();
            }
            return View(menus);
        }

        // GET: menus/Create
        public ActionResult Create()
        {
            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle");
            ViewBag.MenusButtonActionId = new SelectList(db.MenusButtonAction, "Id", "Actiondes");
            ViewBag.pid = new SelectList(db.menus, "Id", "Title", 0);
            return View();
        }

        // POST: menus/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AppTokenInfoId,pid,Title,MenusButtonActionId")] menus menus)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.menus.Add(menus);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
            }

            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", menus.AppTokenInfoId);
            ViewBag.MenusButtonActionId = new SelectList(db.MenusButtonAction, "Id", "Actiondes", menus.MenusButtonActions);
            ViewBag.pid = new SelectList(db.menus, "Id", "Title", 0);
            return View(menus);
        }

        // GET: menus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menus menus = db.menus.Find(id);
            if (menus == null)
            {
                return HttpNotFound();
            }
            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", menus.AppTokenInfoId);
            ViewBag.MenusButtonActionId = new SelectList(db.MenusButtonAction, "Id", "Actiondes", menus.MenusButtonActions);
            ViewBag.pid = new SelectList(db.menus, "Id", "Title", 0);
            return View(menus);
        }

        // POST: menus/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Timestamp,AppTokenInfoId,pid,Title,MenusButtonActionId")] menus menus)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(menus).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = ex.Entries.Single();
                var clientValues = (menus)entry.Entity;
                var databaseEntry = entry.GetDatabaseValues();
                if (databaseEntry == null)
                {
                    ModelState.AddModelError(string.Empty, "无法保存更改，系已经被其他用户删除。");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "无法保存更改，请重试或联系管理员。");
            }
            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", menus.AppTokenInfoId);
            ViewBag.MenusButtonActionId = new SelectList(db.MenusButtonAction, "Id", "Actiondes", menus.MenusButtonActions);
            ViewBag.pid = new SelectList(db.menus, "Id", "Title", 0);
            return View(menus);
        }

        // GET: menus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menus menus = db.menus.Find(id);
            if (menus == null)
            {
                return HttpNotFound();
            }
            return View(menus);
        }

        // POST: menus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            menus menus = db.menus.Find(id);
            db.menus.Remove(menus);
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
