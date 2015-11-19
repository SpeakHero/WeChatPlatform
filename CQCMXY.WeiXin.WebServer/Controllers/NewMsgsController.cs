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
    public class NewMsgsController : BasesController
    {
        private Db db = new Db();

        // GET: NewMsgs
        public ActionResult Index()
        {
            var newMsgs = db.NewMsgs.Include(n => n.AppTokenInfo).Include(n => n.menus).ToList();
            return View(newMsgs);
        }

        // GET: NewMsgs/详细信息/5
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
            ViewBag.meunsId = new SelectList(db.menus, "Id", "Title");
            return View();
        }

        // POST: NewMsgs/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateInput(false)]
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
            ViewBag.meunsId = new SelectList(db.menus, "Id", "Title", newMsgs.meunsId);
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
            ViewBag.meunsId = new SelectList(db.menus, "Id", "Title", newMsgs.meunsId);
            return View(newMsgs);
        }

        // POST: NewMsgs/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Timestamp,AppTokenInfoId,Title,Contents,CreateTime,UpTime,Author,meunsId")] NewMsgs newMsgs)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    if (ModelState.IsValid)
                    {
                        db.Entry(newMsgs).State = EntityState.Modified;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    var entry = ex.Entries.Single();
                    var clientValues = (NewMsgs)entry.Entity;
                    var databaseEntry = entry.GetDatabaseValues();
                    if (databaseEntry == null)
                    {
                        ModelState.AddModelError(string.Empty, "无法保存更改，系已经被其他用户删除。");
                    }
                    else
                    {
                        var databaseValues = (NewMsgs)databaseEntry.ToObject();
                        ModelState.AddModelError(string.Empty, "当前记录已经被其他人更改。如果你仍然想要保存这些数据，"
                        + "重新点击保存按钮或者点击返回列表撤销本次操作。");
                        newMsgs.Timestamp = databaseValues.Timestamp;
                    }
                }
                catch (RetryLimitExceededException)
                {
                    ModelState.AddModelError(string.Empty, "无法保存更改，请重试或联系管理员。");
                }

            }
            ViewBag.AppTokenInfoId = new SelectList(db.AppTokenInfo, "Id", "AppTitle", newMsgs.AppTokenInfoId);
            ViewBag.meunsId = new SelectList(db.menus, "Id", "Title", newMsgs.meunsId);
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
