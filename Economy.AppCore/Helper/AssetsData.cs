using Economy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.AppCore.Helper
{
    public class AssetsData
    {
        public static Asset[] assets =
        {
            // Activos Depreciables
            new Asset("Construcciones y edificaciones", "", "45", true),
            new Asset("Acueducto, planta y redes", "", "40", true),
            new Asset("Vías de comunicación", "", "40", true),
            new Asset("Flota y equipo aéreo", "", "30", true),
            new Asset("Flota y equipo férreo", "", "20", true),
            new Asset("Flota y equipo fluvial", "", "15", true),
            new Asset("Armamento y equipo de vigilancia", "", "10", true),
            new Asset("Equipo eléctrico", "", "10", true),
            new Asset("Flota y equipo de transporte terrestre", "", "10", true),
            new Asset("Maquinaria, equipos", "", "10", true),
            new Asset("Muebles y enseres", "", "10", true),
            new Asset("Equipo médico científico", "", "8", true),
            new Asset("Envases, empaques y herramientas", "", "5", true),
            new Asset("Equipo de computación", "", "5", true),
            new Asset("Redes de procesamiento de datos", "", "5", true),
            new Asset("Equipo de comunicación", "", "5", true),
            new Asset("Vehículos", "", "5", true),

            // Activos No Depreciables
            new Asset("Terrenos", "", "--", false),
            new Asset("Capital de trabajo", "", "--", false),
        };
    }
}
