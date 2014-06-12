/**
 * IPagosService.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface IPagosService extends java.rmi.Remote {
    public org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago[] listarTipoPago() throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje registrarTipoPago(java.lang.String descripcion) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje registrarCuota(java.lang.String pPeriodo, java.lang.Integer pIdVivienda, java.lang.Double pImporte, java.sql.Date pFecVncto) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje;
    public org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje actualizarCuota(java.lang.Integer pIdCuota, java.lang.String pPeriodo, java.lang.Integer pIdVivienda, java.lang.Double pImporte, java.lang.String pFecVncto) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje;
    public org.datacontract.schemas._2004._07.Architecs_PagosService.Cuota[] listarCuota(java.lang.String pPeriodo) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje;
    public org.datacontract.schemas._2004._07.Architecs_PagosService.Cuota buscarCuota(java.lang.Integer pIdCuota) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje;
    public org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje eliminarCuota(java.lang.Integer pIdCuota) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje;
}
