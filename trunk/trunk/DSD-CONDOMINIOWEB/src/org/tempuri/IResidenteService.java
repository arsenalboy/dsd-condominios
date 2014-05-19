/**
 * IResidenteService.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public interface IResidenteService extends java.rmi.Remote {
    public java.lang.Integer crearResidente(java.lang.Integer n_IdResidente, java.lang.String c_Nombre, java.lang.String c_Apellidos, java.lang.Integer n_TipoDoc, java.lang.String c_NumDocume, java.util.Calendar d_FecNacimi, java.lang.String c_Correo, java.lang.String c_Clave, java.lang.Boolean b_Estado) throws java.rmi.RemoteException;
    public java.lang.Integer actualizaResidente(java.lang.Integer n_IdResidente, java.lang.String c_Nombre, java.lang.String c_Apellidos, java.lang.Integer n_TipoDoc, java.lang.String c_NumDocume, java.util.Calendar d_FecNacimi, java.lang.String c_Correo, java.lang.String c_Clave, java.lang.Boolean b_Estado) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.Residente obtenerResidente(java.lang.Integer n_IdResidente) throws java.rmi.RemoteException;
    public org.datacontract.schemas._2004._07.Architects_Dominio.Residente[] listarResidente() throws java.rmi.RemoteException;
}
