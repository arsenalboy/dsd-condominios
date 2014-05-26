using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Architects.Dominio;

namespace Architects.Persistencia
{
    public interface IResidenteDA
    {
        ResidenteBE[] ListarResidentes();        
        Int32 CrearResidente(ResidenteBE prmResidente);
        void ActualizarResidente(ResidenteBE prmResidente);
        void EliminarResidente(int residenteID);

    }
}
