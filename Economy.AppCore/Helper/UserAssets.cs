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
        public static IEnumerable<Activo> AssetsExtraction()
        {
            List<Activo> assets = UAssets.Select(x => x.Asset).ToList();
            return assets;
        }

        public static IEnumerable<dynamic> DataExtraction()
        {
            dynamic result = (from UAssets in UAssets.ToList()
                              join Assets in AssetsData.assets.ToList()
                              on UAssets.Asset.NombreActivo equals Assets.NombreActivo
                              where UAssets.Asset.NombreActivo == Assets.NombreActivo
                              select new {
                                  NombreActivo = Assets.NombreActivo,
                                  VidaUtil = Assets.VidaUtil,
                                  Depreciable = Assets.Depreciable,
                                  Monto = UAssets.AssetAmount
                              }).ToList();
            return result;
        }
    }
}
