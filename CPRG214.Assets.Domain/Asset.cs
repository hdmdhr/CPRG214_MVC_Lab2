using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CPRG214.Assets.Domain
{
    public class Asset
    {
        public int Id { get; set; }
        [Required, DisplayName("Tag No")]
        public string TagNumber { get; set; }
        [Required]
        public string Manufacturer { get; set; }

        public string Model { get; set; }
        [Required]
        public string Description { get; set; }
        [Required, DisplayName("Serial No")]
        public string SerialNumber { get; set; }
        // FK
        [DisplayName("Asset Type")]
        public int AssetTypeId { get; set; }
        // relational property
        public AssetType AssetType { get; set; }

    }
}
