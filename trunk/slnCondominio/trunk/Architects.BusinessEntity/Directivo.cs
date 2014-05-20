using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace Architects.Dominio
{
    [DataContract]
    public class Directivo
    {
        [DataMember]
        int N_IdDirectivo { get; set; }
        [DataMember]
        string C_NomPer { get; set; }
        [DataMember]
        string C_Cargo { get; set; }
        [DataMember]
        int N_IdResidente { get; set; }
        [DataMember]
        Boolean B_Estado { get; set; }
    }
}
