using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Architects.Dominio;
using Arquitects.Negocio;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ResidenteService2" en el código, en svc y en el archivo de configuración a la vez.
    public class ResidenteService : IResidenteService
    {
        ResidenteBL objresidenteBL = new ResidenteBL();

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
            return objresidenteBL.CreaResidente(objresidente);
        }
        public Int32 ActualizaResidente(int n_IdResidente, string c_Nombre, string c_Apellidos, int n_TipoDoc, string c_NumDocume, DateTime D_FecNacimi, string c_Correo, string c_Clave, Boolean b_Estado)
        {
            Residente objresidente = new Residente();
            objresidente.N_IdResidente = n_IdResidente;
            objresidente.C_Nombre = c_Nombre;
            objresidente.C_Apellidos = c_Apellidos;
            objresidente.N_TipoDoc = n_TipoDoc;
            objresidente.C_NumDocume = c_NumDocume;
            objresidente.D_FecNacimi = D_FecNacimi;
            objresidente.C_Correo = c_Correo;
            objresidente.C_Clave = c_Clave;
            objresidente.B_Estado = b_Estado;
            return objresidenteBL.ActualizaResidente(objresidente);
        }
              

        public List<Residente> ListarResidente()
        {
            return objresidenteBL.ListarResidente();
        }


        public Residente ObtenerResidente(int n_IdResidente)
        {
            return objresidenteBL.ObtenerResidente(n_IdResidente);
        }
    }
}
