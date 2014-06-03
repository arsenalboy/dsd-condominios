using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using VisitasService.Dominio;
using Architects.Dominio;

namespace VisitasService.Persistencia
{
    interface IVisitanteDA
    {
        int AgregarVisitante(VisitanteBE prmVisitante);
        VisitanteBE[] BuscarVisitantes(string numDocumento, string nombre, DateTime? fechaVisita, int idResidente);
        VisitanteBE[] ListarVisitantes();
    }
}
