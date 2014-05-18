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
	/// Fecha       : 17/05/2014-08:28:42 a.m.
	/// Descripcion : Capa de Entidades 
	/// Archivo     : [Maestros.TipoPago.cs]
	/// </summary>
    [DataContract]
    public class TipoPago
	{
        [DataMember]
		public  int N_IdTipoPago { get; set; }
        [DataMember]
		public  string C_Descripcion { get; set; }
        [DataMember]
		public  bool B_Estado { get; set; }
	} 
} 
