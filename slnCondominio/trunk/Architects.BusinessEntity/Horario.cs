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
	/// Archivo     : [Gestion.Horario.cs]
	/// </summary>
    [DataContract]
    public class Horario
    {
        [DataMember]
        public int N_IdHorario { get; set; }
        [DataMember]
        public string C_Rango { get; set; }
        [DataMember]
        public bool B_Estado { get; set; }
    }
} 
