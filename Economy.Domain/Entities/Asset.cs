using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Entities
{
    public class Asset
    {
        public Asset(string assetName, string assetDescription, string usefulLife, bool depreciable)
        {
            AssetName = assetName;
            AssetDescription = assetDescription;
            UsefulLife = usefulLife;
            Depreciable = depreciable;
        }

        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public string UsefulLife { get; set; }
        public bool Depreciable { get; set; }
    }
}
