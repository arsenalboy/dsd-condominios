using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architecs.Test.Entidades
{

    public class QuejaConsulta
    {

        public int N_IdQueja { get; set; }
        public int N_IdResidente { get; set; }
        public string C_Tipo { get; set; }
        public string C_Motivo { get; set; }
        public string C_Detalle { get; set; }
        public DateTime D_FecRegistro { get; set; }
        public Boolean B_Estado { get; set; }
        public string C_Nombre { get; set; }
        public string C_NumDocume { get; set; }
        public string D_FecQueja { get; set; }
    }
}