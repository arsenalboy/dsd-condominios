using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architecs.Presentacion.Dominio
{
    public class Directivo
    {
        public int N_IdDirectivo { get; set; }
        public string C_NomPer { get; set; }
        public string C_Cargo { get; set; }
        public int N_IdResidente { get; set; }
        public Boolean B_Estado { get; set; }
    }
}