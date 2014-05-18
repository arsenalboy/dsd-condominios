using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Condominio.Entities 
{ 
	/// <summary>
	/// Proyecto    : Modulo de Mantenimiento de : 
	/// Creacion    : OCARRIL
	/// Fecha       : 17/05/2014-08:27:00 a.m.
	/// Descripcion : Capa de Entidades 
	/// Archivo     : [Gestion.Cuota.cs]
	/// </summary>
    [DataContract]
    public class Cuota
    {
        [DataMember]
        public int N_IdCuota { get; set; }
        [DataMember]
        public string C_Periodo { get; set; }
        [DataMember]
        public int N_IdVivienda { get; set; }
        [DataMember]
        public int N_IdTipoPago { get; set; }
        [DataMember]
        public decimal N_Importe { get; set; }
        [DataMember]
        public string D_FecVncto { get; set; }
        [DataMember]
        public string D_FecPago { get; set; }

        [DataMember]
        public TipoPago objTipoPago { get; set; }
        [DataMember]
        public Vivienda objVivienda { get; set; }
    } 
} 
