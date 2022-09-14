using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public  class Depreciations
    {   
        public string Nombre { get; set; }
       public  string TipodePorducto { get; set; }
        public double valor { get; set; }
        public double vr { get; set; }
        public int vida { get; set; }
        List<Depreciations> depreciations { get; set; }


    }
}
