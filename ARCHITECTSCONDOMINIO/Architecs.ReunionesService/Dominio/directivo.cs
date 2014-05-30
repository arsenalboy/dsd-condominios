using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architecs.ReunionesService.Dominio
{
    [DataContract]
    public class directivo
    {
        [DataMember]
        public int N_IdDirectivo { get; set; }
        [DataMember]
        public string C_NomPer { get; set; }
        [DataMember]
        public string C_Cargo { get; set; }
        [DataMember]
        public int N_IdResidente { get; set; }
        [DataMember]
        public Boolean B_Estado { get; set; }
    }
}