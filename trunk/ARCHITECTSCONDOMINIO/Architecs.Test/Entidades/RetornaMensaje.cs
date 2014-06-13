using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecs.Test.Entidades
{
    public class RetornaMensaje
    {
        public string Mensage { get; set; }
        public int CodigoRetorno { get; set; }
        public string CodigoError { get; set; }
        public bool Exito { get; set; }
    }
}
