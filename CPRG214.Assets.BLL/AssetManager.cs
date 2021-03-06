﻿using System;
using System.Collections.Generic;
using System.Linq;
using CPRG214.Assets.Data;
using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;

namespace CPRG214.Assets.BLL
{
    public class AssetManager
    {
        // get all
        public static List<Asset> GetAllAssets()
        {
            var context = new AssetsContext();
            return context.Assets.
                Include(a => a.AssetType).
                OrderBy(a => a.AssetTypeId).
                ToList();
        }
        // get a certain type assets
        public static List<Asset> GetAssetsById(int id)
        {
            var context = new AssetsContext();
            return context.Assets.
                Where(a => a.AssetTypeId == id).
                Include(a => a.AssetType).
                ToList();
        }
        // add a new asset
        public static void AddNewAsset(Asset asset)
        {
            var context = new AssetsContext();
            context.Assets.Add(asset);
            context.SaveChanges();
        }
    }
}
