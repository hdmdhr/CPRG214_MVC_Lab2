using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CPRG214.Assets.BLL;
using CPRG214.Assets.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CPRG214.Assets.App.ViewComponents
{
    public class AssetsByTypeViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<Domain.Asset> assets = null;
            // when id is 0, get all assets
            assets = id == 0 ? AssetManager.GetAllAssets() : AssetManager.GetAssetsById(id);

            return View(assets);
        }
    }
}
