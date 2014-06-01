using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Architects.Dominio
{
    [DataContract]
    public class ResidenteBE
    {
        [DataMember]
        public int N_IdResidente { get; set; }
        [DataMember]
        public string C_Nombre { get; set; }
        [DataMember]
        public string C_Apellidos { get; set; }
        [DataMember]
        public int N_TipoDoc { get; set; }
        [DataMember]
        public string C_NumDocume { get; set; }
        [DataMember]
        public DateTime D_FecNacimi { get; set; }
        [DataMember]
        public string C_Correo { get; set; }
        [DataMember]
        public string C_Clave { get; set; }
        [DataMember]
        public Boolean B_Estado { get; set; }
    }
}
