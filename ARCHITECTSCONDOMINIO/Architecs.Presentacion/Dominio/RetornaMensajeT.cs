using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecs.Presentacion.Dominio
{
    public class RetornaMensajeT
    {
        public string Mensage { get; set; }
        public int CodigoRetorno { get; set; }
        public string CodigoError { get; set; }
        public bool Exito { get; set; }
    }
}
