using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Architecs.QuejasService.Dominio;
using Architecs.QuejasService.Persistencia;

namespace Architecs.QuejasService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "QuejaService" en el código, en svc y en el archivo de configuración a la vez.
    public class QuejaService : IQuejaService
    {
        private QuejaDAO ObjQUejaDAO = new QuejaDAO();

        public Queja CrearQueja(Queja QuejaCrear)
        {
            return ObjQUejaDAO.CreaQueja(QuejaCrear);
        }

        public List<Queja> ListarQuejas(string FechaIni, string FechaFin, string C_Tipo)
        {
            return ObjQUejaDAO.listarQuejas(FechaIni, FechaFin, C_Tipo);
        }


        public void Actualizar(string N_IdQueja, string B_Estado)
        {
            ObjQUejaDAO.Actualizar(N_IdQueja, B_Estado);
        }
    }
}