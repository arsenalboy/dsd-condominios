using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Architects.Dominio
{ 
	/// <summary>
	/// Proyecto    : Modulo de Mantenimiento de : 
	/// Creacion    : 
	/// Fecha       : 16/05/2014-07:59:42 a.m.
	/// Descripcion : Capa de Entidades 
	/// Archivo     : [Gestion.Reservas.cs]
	/// </summary>

    [DataContract]
    public class Reserva
    {
        [DataMember]
        public int N_IdReserva { get; set; }
        [DataMember]
        public int N_IdResidente { get; set; }
        [DataMember]
        public int N_IdHorario { get; set; }
        [DataMember]
        public int N_IdEspacio { get; set; }
        [DataMember]
        public string D_FecRegistro { get; set; }
        [DataMember]
        public bool B_Estado { get; set; }
    } 
} 
