using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CPRG214.Assets.Data;
using CPRG214.Assets.Domain;
using Microsoft.EntityFrameworkCore;

namespace CPRG214.Assets.BLL
{
    public class AssetTypeManager
    {
        public static List<AssetType> GetAllAssetTypes()
        {
            var context = new AssetsContext();
            return context.AssetTypes.ToList();
        }
    }
}
