using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;

namespace WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IResidenteService2" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IResidenteService
    {
        [OperationContract]
        Int32 CrearResidente(int n_IdResidente, string c_Nombre, string c_Apellidos, int n_TipoDoc, string c_NumDocume, DateTime D_FecNacimi, string c_Correo, string c_Clave, Boolean b_Estado);
        [OperationContract]
        Int32 ActualizaResidente(int n_IdResidente, string c_Nombre, string c_Apellidos, int n_TipoDoc, string c_NumDocume, DateTime D_FecNacimi, string c_Correo, string c_Clave, Boolean b_Estado);
        [OperationContract]
        Residente ObtenerResidente(int n_IdResidente);
        //[OperationContract]
        //Residente ModificarResidente(int n_IdRes, string c_NomRes, int n_TipDoc, DateTime d_FecNac, string c_Correo, string c_NumDoc, string c_Clave, string c_EstReg);
        //[OperationContract]
        //void EliminarResidente(int n_IdRes);
        [OperationContract]
        List<Residente> ListarResidente();
    }
}
