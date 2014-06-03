using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Architects.Dominio;

namespace Architecs.QuejasService.Dominio
{
    [DataContract]
    public class Queja
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
        public string  C_Detalle { get; set; }
        [DataMember]
        public DateTime D_FecRegistro { get; set; }
        [DataMember]
        public Boolean B_Estado { get; set; }
        [DataMember]
        public ResidenteBE Residente { get; set; }
        [DataMember]
        public string D_FecQueja { get; set; }
    }
}