using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Architects.Dominio
{
    [DataContract]
    public class ViviendaBE
    {
        public ViviendaBE()
        {
            objResidente = new ResidenteBE();
        }

        [DataMember]
        public int N_IdVivienda { get; set; }
        [DataMember]
        public int N_IdResidente { get; set; }
        [DataMember]
        public string C_NumEdificio { get; set; }
        [DataMember]
        public string C_NumDpto { get; set; }
        [DataMember]
        public decimal N_NumMetros { get; set; }
        [DataMember]
        public string C_CodTipo { get; set; }
        [DataMember]
        public bool B_Estado { get; set; }

        [DataMember]
        public ResidenteBE objResidente { get; set; }
    }
}
