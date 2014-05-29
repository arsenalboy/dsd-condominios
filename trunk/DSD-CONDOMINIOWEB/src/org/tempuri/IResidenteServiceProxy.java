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
  
  public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] listarResidentes() throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.listarResidentes();
  }
  
  public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] buscarResidentes(java.lang.String nombre, java.lang.String apellidos, java.lang.String numDocumento) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.buscarResidentes(nombre, apellidos, numDocumento);
  }
  
  public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] listarResidentesPaginado(java.lang.Integer page, java.lang.Integer size) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.listarResidentesPaginado(page, size);
  }
  
  public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE obtenerResidentePorID(java.lang.Integer residenteId) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.obtenerResidentePorID(residenteId);
  }
  
  public java.lang.Integer crearResidente(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE prmResidente) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.crearResidente(prmResidente);
  }
  
  public org.datacontract.schemas._2004._07.ResidenteService.ValidationException actualizarResidente(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE prmResidente) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.actualizarResidente(prmResidente);
  }
  
  public org.datacontract.schemas._2004._07.ResidenteService.ValidationException eliminarResidente(java.lang.Integer residenteID) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException{
    if (iResidenteService == null)
      _initIResidenteServiceProxy();
    return iResidenteService.eliminarResidente(residenteID);
  }
  
  
}