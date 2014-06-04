using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Architecs.Dominio
{
    [DataContract]
    public class EspacioComunBE
    {
        [DataMember]
        public int N_IdEspacio { get; set; }
        [DataMember]
        public string C_Nombre { get; set; }
        [DataMember]
        public int B_Estado { get; set; }
    }
}
