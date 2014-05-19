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
	/// Archivo     : [Maestros.EspacioComun.cs]
	/// </summary>
    [DataContract]
    public class EspacioComun
	{
        [DataMember]
		public  int N_IdEspacioComun { get; set; }
        [DataMember]
		public  string C_Nombre { get; set; }
        [DataMember]
		public  bool B_Estado { get; set; }
	} 
} 
