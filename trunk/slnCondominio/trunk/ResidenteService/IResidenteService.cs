using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;
namespace WCFService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IResidenteService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IResidenteService
    {
        //[OperationContract]
        //Residente CrearResidente(int n_IdRes, string c_NomRes, int n_TipDoc, DateTime d_FecNac, string c_Correo, string c_NumDoc, string c_Clave, string c_EstReg);
        //[OperationContract]
        //Residente ObtenerResidente(int n_IdRes);
        //[OperationContract]
        //Residente ModificarResidente(int n_IdRes, string c_NomRes, int n_TipDoc, DateTime d_FecNac, string c_Correo, string c_NumDoc, string c_Clave, string c_EstReg);
        //[OperationContract]
        //void EliminarResidente(int n_IdRes);
        [OperationContract]
        List<Residente> ListarResidente();

    }
}
