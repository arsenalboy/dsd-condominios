/**
 * IResidenteService.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface IResidenteService extends java.rmi.Remote {
    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] listarResidentes() throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] buscarResidentes(java.lang.String nombre, java.lang.String apellidos, java.lang.String numDocumento) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] listarResidentesPaginado(java.lang.Integer page, java.lang.Integer size) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE obtenerResidentePorID(java.lang.Integer residente) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE obtenerResidentePorNroDocumento(java.lang.String numeroDocumento) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException;
    public java.lang.Integer crearResidente(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE prmResidente) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException actualizarResidente(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE prmResidente) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException eliminarResidente(java.lang.Integer residenteID) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.ValidationException;
}
