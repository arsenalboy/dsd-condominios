using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architecs.ReservasService.Dominio
{
    [DataContract]
    public class EspacioComunBE
    {
        [DataMember]
        public int N_IdEspacioComun { get; set; }
        [DataMember]
        public string C_Nombre { get; set; }
        [DataMember]
        public Boolean B_Estado { get; set; }
    }
}