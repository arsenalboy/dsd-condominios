using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architects.Dominio
{
    [DataContract]
    public class RetornaMensaje
    {
        [DataMember]
        public string Mensage { get; set; }
        [DataMember]
        public int CodigoRetorno { get; set; }
        [DataMember]
        public string CodigoError { get; set; }
        [DataMember]
        public bool Exito { get; set; }
    }
}