using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Architecs.ReservasService.Dominio
{
    [DataContract]
    public class ReservasBE
    {
        [DataMember]
        public int N_IdReserva { get; set; }
        [DataMember]
        public int N_IdResidente { get; set; }
        [DataMember]
        public int N_IdHorarioIni { get; set; }
        [DataMember]
        public int N_IdHorarioFin { get; set; }
        [DataMember]
        public int N_IdEspacioComun { get; set; }
        [DataMember]
        public DateTime D_FecRegistro { get; set; }
        [DataMember]
        public Boolean B_Estado { get; set; }
    }
}