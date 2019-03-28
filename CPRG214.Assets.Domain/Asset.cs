using System;
using System.ComponentModel.DataAnnotations;

namespace CPRG214.Assets.Domain
{
    public class Asset
    {
        public int Id { get; set; }
        [Required]
        public string TagNumber { get; set; }
        [Required]
        public string Manufacturer { get; set; }

        public string Model { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string SerialNumber { get; set; }
        // FK
        public int AssetTypeId { get; set; }
        // relational property
        public AssetType AssetType { get; set; }

    }
}
