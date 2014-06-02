using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Architects.Dominio
{
    [DataContract]
    public class HorarioBE
    {
        [DataMember]
        public int N_IdHorario { get; set; }
        [DataMember]
        public string C_Rango { get; set; }
        [DataMember]
        public int B_Estado { get; set; }
    }
}
