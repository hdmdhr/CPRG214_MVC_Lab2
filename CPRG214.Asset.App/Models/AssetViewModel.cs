using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CPRG214.Assets.App.Models
{
    public class AssetViewModel
    {
        // properties from domain entity "Asset"
        [DisplayName("Tag No")]
        public string TagNumber { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        [DisplayName("Serial No")]
        public string SerialNumber { get; set; }
        // FK
        [DisplayName("Asset Type")]
        public int? AssetTypeId { get; set; }

        // List of SelectListItem
        public List<SelectListItem> Types { get; set; }
    }
}
