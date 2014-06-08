using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architecs.Presentacion.Dominio
{
    [DataContract]
    public class ListaJuntas
    {
        [DataMember]
        public int N_IdJunta { get; set; }
        [DataMember]
        public string D_Fecha { get; set; }
        [DataMember]
        public string C_Hora { get; set; }
        [DataMember]
        public string C_Tema { get; set; }
        [DataMember]
        public string C_Acuerdo { get; set; }
        [DataMember]
        public string C_NomPer { get; set; }
        [DataMember]
        public string C_Cargo { get; set; }
        [DataMember]
        public string C_PREJUN { get; set; }
    }
}