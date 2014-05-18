using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Persistencia;
using Architects.Dominio;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ResidenteService2" en el código, en svc y en el archivo de configuración a la vez.
    public class ResidenteService : IResidenteService
    {
        ResidenteDAO objresidenteDAO = new ResidenteDAO();
        public Int32 CrearResidente(int n_IdResidente, string c_Nombre, string c_Apellidos, int n_TipoDoc, string c_NumDocume, DateTime D_FecNacimi, string c_Correo, string c_Clave, Boolean b_Estado)
        {
            Residente objresidente = new Residente();
            objresidente.C_Nombre = c_Nombre;
            objresidente.C_Apellidos = c_Apellidos;
            objresidente.N_TipoDoc = n_TipoDoc;
            objresidente.C_NumDocume = c_NumDocume;
            objresidente.D_FecNacimi = D_FecNacimi;
            objresidente.C_Correo = c_Correo;            
            objresidente.C_Clave = c_Clave;
            objresidente.B_Estado = b_Estado;
            return objresidenteDAO.CreaResidente(objresidente);
        }

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

        public List<Residente> ListarResidente()
        {
            return objresidenteDAO.ListarResidentes();
        }
    }
}
