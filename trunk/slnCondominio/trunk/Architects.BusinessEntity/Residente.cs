using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architects.Dominio
{
    [DataContract]
    public class Residente
    {
        [DataMember]
        public int N_IdRes { get; set; }
        [DataMember]
        public string C_NomRes { get; set; }
        [DataMember]
        public int N_TipDoc { get; set; }
        [DataMember]
        public DateTime D_FecNac { get; set; }
        [DataMember]
        public string C_Correo { get; set; }
        [DataMember]
        public string C_NumDoc { get; set; }
        [DataMember]
        public string C_Clave { get; set; }
        [DataMember]
        public string C_EstReg { get; set; }


    }
}