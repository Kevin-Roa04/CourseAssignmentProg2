using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Helper
{
    public class UserAssets
    {
        public static List<UserAsset> UAssets = new List<UserAsset>();
        public static IEnumerable<Asset> AssetsExtraction()
        {
            List<Asset> assets = UAssets.Select(x => x.Asset).ToList();
            return assets;
        }

        public static IEnumerable<dynamic> DataExtraction()
        {
            dynamic result = (from UAssets in UAssets.ToList()
                              join Assets in AssetsData.assets.ToList()
                              on UAssets.Asset.AssetName equals Assets.AssetName
                              where UAssets.Asset.AssetName == Assets.AssetName
                              select new {
                                  AssetName = Assets.AssetName,
                                  AssetDescription = Assets.AssetDescription,
                                  UsefulLife = Assets.UsefulLife,
                                  Depreciable = Assets.Depreciable,
                                  AssetAmount = UAssets.AssetAmount
                              }).ToList();
            return result;
        }
    }
}
