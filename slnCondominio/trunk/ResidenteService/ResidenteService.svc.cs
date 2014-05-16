using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Persistencia;

namespace WCFService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ResidenteService" en el código, en svc y en el archivo de configuración a la vez.
    public class ResidenteService : IResidenteService
    {
        ResidenteDAO objresidenteDAO = new ResidenteDAO();
        //public Architects.Dominio.Residente CrearResidente(int n_IdRes, string c_NomRes, int n_TipDoc, DateTime d_FecNac, string c_Correo, string c_NumDoc, string c_Clave, string c_EstReg)
        //{
        //    throw new NotImplementedException();
        //}

        //public Architects.Dominio.Residente ObtenerResidente(int n_IdRes)
        //{
        //    throw new NotImplementedException();
        //}

        //public Architects.Dominio.Residente ModificarResidente(int n_IdRes, string c_NomRes, int n_TipDoc, DateTime d_FecNac, string c_Correo, string c_NumDoc, string c_Clave, string c_EstReg)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EliminarResidente(int n_IdRes)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Architects.Dominio.Residente> ListarResidente()
        {
            return objresidenteDAO.ListarResidentes();
        }
    }
}
