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
        //public static List<UserAsset> UAssets = new List<UserAsset>();
        public static List<InversionFne> UAssets { get; set; }
        public static IEnumerable<Activo> AssetsExtraction()
        {
            List<Activo> assets = UAssets.Select(x => x.Activo).ToList();
            return assets;
        }

        public static IEnumerable<dynamic> DataExtraction()
        {
            var resultado = (from UserAssets in UAssets.ToList()
                             select new
                             {
                                 NombreActivo = UserAssets.Activo.NombreActivo,
                                 VidaUtil = UserAssets.Activo.VidaUtil,
                                 Depreciable = UserAssets.Activo.Depreciable,
                                 Monto = Math.Round(UserAssets.Monto)
                             }).ToList();


            //dynamic result = (from UAssets in UAssets.ToList()
            //                  join Assets in AssetsData.assets.ToList()
            //                  on UAssets.Activo.NombreActivo equals Assets.NombreActivo
            //                  where UAssets.Activo.NombreActivo == Assets.NombreActivo
            //                  select new{
            //                      NombreActivo = Assets.NombreActivo,
            //                      VidaUtil = Assets.VidaUtil,
            //                      Depreciable = Assets.Depreciable,
            //                      Monto = UAssets.Monto
            //                  }).ToList();
            return resultado;
        }
    }
}
