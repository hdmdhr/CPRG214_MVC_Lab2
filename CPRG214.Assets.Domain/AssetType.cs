using System;
using System.Collections.Generic;
using System.Text;

namespace CPRG214.Assets.Domain
{
    public class AssetType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // relational property
        public ICollection<Asset> Assets { get; set; }

    }
}
