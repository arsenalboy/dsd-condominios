using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Architects.Dominio;
using Architects.Persistencia;

namespace ResidenteService
{    
    public class ResidenteService : IResidenteService
    {
        IResidenteDA objDA = new ResidenteDA();
        ValidationException vExc = null;
        
        public ResidenteBE[] ListarResidentes()
        {
            try
            {
                return objDA.ListarResidentes();
            }
            catch (Exception ex)
            {
                throw new FaultException<ValidationException>
                    (new ValidationException { ValidationError = ex.Message }, 
                    new FaultReason("Validation Failed"));
            }
        }

        public ResidenteBE[] BuscarResidentes(string nombre, string apellidos, string numDocumento)
        {
            try
            {
                return objDA.BuscarResidentes(nombre, apellidos, numDocumento);
            }
            catch (Exception ex)
            {
                throw new FaultException<ValidationException>
                    (new ValidationException { ValidationError = ex.Message },
                    new FaultReason("Validation Failed"));
            }
        }

        public IEnumerable<ResidenteBE> ListarResidentesPaginado(int page, int size)
        {
            List<ResidenteBE> listaResidentes = null;

            try
            {
                listaResidentes = new List<ResidenteBE>(ListarResidentes());

                return listaResidentes.OrderBy(c => c.N_IdResidente).Skip(page * size).Take(size);
            }
            catch (Exception ex)
            {
                throw new FaultException<ValidationException>
                    (new ValidationException { ValidationError = ex.Message },
                    new FaultReason("Validation Failed"));
            }         
        }

        public ResidenteBE ObtenerResidentePorID(int residenteId)
        {
            List<ResidenteBE> listaResidentes = null;
            ResidenteBE result = null;
            
            try
            {
                listaResidentes = new List<ResidenteBE>(ListarResidentes());

                var nres = from l in listaResidentes
                          where l.N_IdResidente == residenteId
                          select l;

                foreach (var item in nres)
                {
                    result = new ResidenteBE();
                    result.N_IdResidente = item.N_IdResidente;
                    result.C_Nombre = item.C_Nombre;
                    result.C_Apellidos = item.C_Apellidos;
                    result.B_Estado = item.B_Estado;
                    result.N_TipoDoc = item.N_TipoDoc;
                    result.C_NumDocume = item.C_NumDocume;
                    result.D_FecNacimi = item.D_FecNacimi;
                    result.C_Correo = item.C_Correo;                    
                }
                
                return result;
            }
            catch (Exception ex)
            {
                throw new FaultException<ValidationException>
                    (new ValidationException { ValidationError = ex.Message },
                    new FaultReason("Validation Failed"));
            }
        }

        public int CrearResidente(ResidenteBE prmResidente)
        {
            try
            {
                return objDA.CrearResidente(prmResidente);
            }
            catch (Exception ex)
            {
                throw new FaultException<ValidationException>
                    (new ValidationException { ValidationError = ex.Message },
                    new FaultReason("Validation Failed"));
            }
        }

        public ValidationException ActualizarResidente(ResidenteBE prmResidente)
        {
            vExc = new ValidationException();

            try
            {
                objDA.ActualizarResidente(prmResidente);
                vExc.ValidationError = string.Format(resMensajes.msjGuardadoOK, "Residente");
                return vExc;
            }
            catch (Exception ex)
            {
                throw new FaultException<ValidationException>
                    (new ValidationException { ValidationError = string.Format(resMensajes.msjNoRegistrado, "Residente") },
                    new FaultReason(ex.Message));
            }
        }

        public ValidationException EliminarResidente(int residenteID)
        {
            vExc = new ValidationException();

            try
            {
                objDA.EliminarResidente(residenteID);
                vExc.ValidationError = string.Format(resMensajes.msjEliminadoOK, "Residente");
                return vExc;
            }
            catch (Exception ex)
            {
                throw new FaultException<ValidationException>
                    (new ValidationException { ValidationError = string.Format(resMensajes.msjNoEliminado, "Residente") },
                    new FaultReason(ex.Message));
            }
        }

        public ResidenteBE ObtenerResidentePorNroDocumento(string numeroDocumento)
        {
            List<ResidenteBE> listaResidentes = null;
            ResidenteBE result = null;

            try
            {
                listaResidentes = new List<ResidenteBE>(ListarResidentes());

                var nres = from l in listaResidentes
                           where l.C_NumDocume == numeroDocumento
                           select l;

                foreach (var item in nres)
                {
                    result = new ResidenteBE();
                    result.N_IdResidente = item.N_IdResidente;
                    result.C_Nombre = item.C_Nombre;
                    result.C_Apellidos = item.C_Apellidos;
                    result.B_Estado = item.B_Estado;
                    result.N_TipoDoc = item.N_TipoDoc;
                    result.C_NumDocume = item.C_NumDocume;
                    result.D_FecNacimi = item.D_FecNacimi;
                    result.C_Correo = item.C_Correo;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new FaultException<ValidationException>
                    (new ValidationException { ValidationError = ex.Message },
                    new FaultReason("Validation Failed"));
            }
        }
    }
}
