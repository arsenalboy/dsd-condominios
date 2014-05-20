package org.tempuri;

public class IResidenteServiceProxy implements org.tempuri.IResidenteService {
  private String _endpoint = null;
  private org.tempuri.IResidenteService iResidenteService = null;
  
  public IResidenteServiceProxy() {
    _initIResidenteServiceProxy();
  }
  
  public IResidenteServiceProxy(String endpoint) {
    _endpoint = endpoint;
    _initIResidenteServiceProxy();
  }
  
  private void _initIResidenteServiceProxy() {
    try {
      iResidenteService = (new org.tempuri.ResidenteServiceLocator()).getBasicHttpBinding_IResidenteService();
      if (iResidenteService != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)iResidenteService)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)iResidenteService)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (iResidenteService != null)
      ((javax.xml.rpc.Stub)iResidenteService)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.IResidenteService getIResidenteService() {
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService;
  }
  
  public java.lang.Integer crearResidente(java.lang.String c_Nombre, java.lang.String c_Apellidos, java.lang.Integer n_TipoDoc, java.lang.String c_NumDocume, java.util.Calendar d_FecNacimi, java.lang.String c_Correo, java.lang.String c_Clave, java.lang.Boolean b_Estado) throws java.rmi.RemoteException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.crearResidente(c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, d_FecNacimi, c_Correo, c_Clave, b_Estado);
  }
  
  public java.lang.Integer actualizaResidente(java.lang.Integer n_IdResidente, java.lang.String c_Nombre, java.lang.String c_Apellidos, java.lang.Integer n_TipoDoc, java.lang.String c_NumDocume, java.util.Calendar d_FecNacimi, java.lang.String c_Correo, java.lang.String c_Clave, java.lang.Boolean b_Estado) throws java.rmi.RemoteException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.actualizaResidente(n_IdResidente, c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, d_FecNacimi, c_Correo, c_Clave, b_Estado);
  }
  
  public org.datacontract.schemas._2004._07.Architects_Dominio.Residente obtenerResidente(java.lang.Integer n_IdResidente) throws java.rmi.RemoteException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.obtenerResidente(n_IdResidente);
  }
  
  public org.datacontract.schemas._2004._07.Architects_Dominio.Residente[] listarResidente() throws java.rmi.RemoteException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.listarResidente();
  }
  
  
}