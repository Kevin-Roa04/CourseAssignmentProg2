using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Domain.Entities
{
    public class UserAsset
    {
        public UserAsset(Asset Asset, double AssetAmount)
        {
            this.Asset = Asset;
            this.AssetAmount = AssetAmount;
        }

        public Asset Asset { get; set; }
        public double AssetAmount { get; set; }
    }
}
