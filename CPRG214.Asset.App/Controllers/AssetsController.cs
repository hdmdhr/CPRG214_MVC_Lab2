﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG214.Assets.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CPRG214.Assets.Data;
using CPRG214.Assets.Domain;

namespace CPRG214.Asset.App.Controllers
{
    public class AssetsController : Controller
    {

        // GET: Assets
        public IActionResult Index()
        {
            var model = AssetManager.GetAllAssets();

            return View(model);
        }

        //// GET: Assets/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var asset = await _context.Assets
        //        .Include(a => a.AssetType)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (asset == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(asset);
        //}

        //// GET: Assets/Create
        //public IActionResult Create()
        //{
        //    ViewData["AssetTypeId"] = new SelectList(_context.AssetTypes, "Id", "Name");
        //    return View();
        //}

        //// POST: Assets/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,TagNumber,Manufacturer,Model,Description,SerialNumber,AssetTypeId")] Assets.Domain.Asset asset)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(asset);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AssetTypeId"] = new SelectList(_context.AssetTypes, "Id", "Name", asset.AssetTypeId);
        //    return View(asset);
        //}

        //// GET: Assets/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var asset = await _context.Assets.FindAsync(id);
        //    if (asset == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["AssetTypeId"] = new SelectList(_context.AssetTypes, "Id", "Name", asset.AssetTypeId);
        //    return View(asset);
        //}

        //// POST: Assets/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,TagNumber,Manufacturer,Model,Description,SerialNumber,AssetTypeId")] Assets.Domain.Asset asset)
        //{
        //    if (id != asset.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(asset);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!AssetExists(asset.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AssetTypeId"] = new SelectList(_context.AssetTypes, "Id", "Name", asset.AssetTypeId);
        //    return View(asset);
        //}

        //// GET: Assets/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var asset = await _context.Assets
        //        .Include(a => a.AssetType)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (asset == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(asset);
        //}

        //// POST: Assets/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var asset = await _context.Assets.FindAsync(id);
        //    _context.Assets.Remove(asset);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool AssetExists(int id)
        //{
        //    return _context.Assets.Any(e => e.Id == id);
        //}
    }
}
