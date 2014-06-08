using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architects.Dominio;
using Architecs.ReunionesService.Dominio;

namespace Architecs.ReunionesService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IJuntaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IJuntaService
    {
        /* LISTAR DIRECTIVOS POR NOMBRES */
        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "listarDirectivos")]
        List<Directivo> listarDirectivos(string C_NomPer);

        /* INSERTA JUNTA */
        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "CreaJunta")]
        Int32 CreaJunta(DateTime D_Fecha, string C_Hora, string C_Tema, string C_Acuerdo);

           /* INSERTA JUNTA */
        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "CreaJuntaDirectivos")]
        Int32 CreaJuntaDirectivos(int N_IdJunta, int N_IdDirectivo, string C_PreJun, Boolean B_Estado);

        /* LISTAR LAS JUNTAS POR FECHA */
        [FaultContract(typeof(RetornaMensaje))]
        [OperationContract(Name = "listarJuntas")]
        List<ListaJuntas> listarJuntas(string fechaini, string fechafin);
    }
}
