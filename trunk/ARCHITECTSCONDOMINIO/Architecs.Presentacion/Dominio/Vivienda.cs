using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecs.Presentacion.Dominio
{
    public class Vivienda
    {
        public Vivienda()
        {
            objResidente = new ResidenteBE();
        }

        public int N_IdVivienda { get; set; }
        public int N_IdResidente { get; set; }
        public string C_NumEdificio { get; set; }
        public string C_NumDpto { get; set; }
        public decimal? N_NumMetros { get; set; }
        public string C_CodTipo { get; set; }
        public bool B_Estado { get; set; }

        public ResidenteBE objResidente { get; set; }
    }
}
