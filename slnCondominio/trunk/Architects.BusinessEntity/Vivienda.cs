using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Architects.Dominio
{
    /// <summary>
    /// Proyecto    : Modulo de Mantenimiento de : 
    /// Creacion    : LOG(OCR)
    /// Fecha       : 16/05/2014-07:59:42 a.m.
    /// Descripcion : Capa de Entidades 
    /// Archivo     : [Maestros.Vivienda.cs]
    /// </summary>
    [DataContract]
    public class Vivienda
    {
        [DataMember]
        public int N_IdVivienda { get; set; }
        [DataMember]
        public int N_IdResidente { get; set; }
        [DataMember]
        public string C_NumEdificio { get; set; }
        [DataMember]
        public string C_NumDpto { get; set; }
        [DataMember]
        public decimal N_NumMetros { get; set; }
        [DataMember]
        public string C_CodTipo { get; set; }
        [DataMember]
        public bool B_Estado { get; set; }
    }
} 
