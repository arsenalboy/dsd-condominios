﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecs.Presentacion.Dominio
{
    public class ResidenteBE
    {
        public int N_IdResidente { get; set; }
        public string C_Nombre { get; set; }
        public string C_Apellidos { get; set; }
        public int N_TipoDoc { get; set; }
        public string C_NumDocume { get; set; }
        public DateTime D_FecNacimi { get; set; }
        public string C_Correo { get; set; }
        public string C_Clave { get; set; }
        public Boolean B_Estado { get; set; }
    }
}
