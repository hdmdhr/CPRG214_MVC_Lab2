using System;
using System.Collections.Generic;
using System.Linq;
using CPRG214.Assets.Data;
using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;

namespace CPRG214.Assets.BLL
{
    public class AssetManager
    {
        public static List<Asset> GetAllAssets()
        {
            var context = new AssetsContext();
            return context.Assets.
                Include(a => a.AssetType).
                ToList();
        }
    }
}
