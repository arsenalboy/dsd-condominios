using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architecs.Presentacion.Dominio
{
    [DataContract]
    public class QuejaConsulta
    {
        [DataMember]
        public int N_IdQueja { get; set; }
        [DataMember]
        public int N_IdResidente { get; set; }
        [DataMember]
        public string C_Tipo { get; set; }
        [DataMember]
        public string C_Motivo { get; set; }
        [DataMember]
        public string C_Detalle { get; set; }
        [DataMember]
        public DateTime D_FecRegistro { get; set; }
        [DataMember]
        public Boolean B_Estado { get; set; }
        [DataMember]
        public string C_Nombre { get; set; }
        [DataMember]
        public string C_NumDocume { get; set; }
        [DataMember]
        public string D_FecQueja { get; set; }
    }
}