﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Architects.Dominio;

namespace Architecs.ReunionesService.Dominio
{
    [DataContract]
    public class Junta
    {
        [DataMember]
        public int N_IdJunta { get; set; }
        [DataMember]
        public DateTime D_Fecha { get; set; }
        [DataMember]
        public string C_Hora { get; set; }
        [DataMember]
        public string C_Tema { get; set; }
        [DataMember]
        public string C_Acuerdo { get; set; }
        [DataMember]
        public ResidenteBE Residente { get; set; }
    }
}