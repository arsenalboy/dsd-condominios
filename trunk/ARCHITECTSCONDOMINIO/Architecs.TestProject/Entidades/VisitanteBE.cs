using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Architecs.TestProject
{
    [DataContract]
    public class VisitanteBE
    {
        public VisitanteBE()
        {
            O_ResidenteBE = new Residente();
        }

        [DataMember]
        public int N_IdVisitante { get; set; }
        [DataMember]
        public string C_NumDocumento { get; set; }
        [DataMember]
        public string C_Nombre { get; set; }
        [DataMember]
        public Residente O_ResidenteBE { get; set; }
        [DataMember]
        public DateTime D_FecVisita { get; set; }
        [DataMember]
        public bool B_Estado { get; set; }

    }
}