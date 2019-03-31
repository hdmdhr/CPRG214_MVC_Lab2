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
        // get all types
        public static List<AssetType> GetAllAssetTypes()
        {
            var context = new AssetsContext();
            return context.AssetTypes.ToList();
        }
        // get type by id
        public static void Update(AssetType newType)
        {
            var context = new AssetsContext();
            var old = context.AssetTypes.Include(at => at.Assets).
                SingleOrDefault(at => at.Id == newType.Id);
            old.Name = newType.Name;
            context.SaveChanges();
        }
        // add new type
        public static void AddNewType(AssetType type)
        {
            var context = new AssetsContext();
            context.AssetTypes.Add(type);
            context.SaveChanges();
        }
    }
}
