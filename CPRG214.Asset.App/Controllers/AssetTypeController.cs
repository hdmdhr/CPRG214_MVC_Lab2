using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG214.Assets.BLL;
using CPRG214.Assets.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CPRG214.Assets.App.ViewComponents
{
    public class AssetTypeController : Controller
    {
        // GET: AssetTypes
        public ActionResult Index()
        {
            var model = AssetTypeManager.GetAllAssetTypes();
            return View(model);
        }


        // GET: AssetTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssetTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AssetType type)
        {
            try
            {
                AssetTypeManager.AddNewType(type);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: AssetTypes/Edit/5
        public ActionResult Edit(int id)
        {
            var model = AssetTypeManager.GetAllAssetTypes().SingleOrDefault(at => at.Id == id);
            return View(model);
        }

        // POST: AssetTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AssetType type)
        {
            try
            {
                AssetTypeManager.Update(type);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // --------------- NOT IN USE -----------------------------------------


        // GET: AssetTypes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssetTypes/Delete/5
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