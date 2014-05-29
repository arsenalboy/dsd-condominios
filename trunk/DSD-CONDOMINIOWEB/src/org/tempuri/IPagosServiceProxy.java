package org.tempuri;

public class IPagosServiceProxy implements org.tempuri.IPagosService {
  private String _endpoint = null;
  private org.tempuri.IPagosService iPagosService = null;
  
  public IPagosServiceProxy() {
    _initIPagosServiceProxy();
  }
  
  public IPagosServiceProxy(String endpoint) {
    _endpoint = endpoint;
    _initIPagosServiceProxy();
  }
  
  private void _initIPagosServiceProxy() {
    try {
      iPagosService = (new org.tempuri.PagosServiceLocator()).getBasicHttpBinding_IPagosService();
      if (iPagosService != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)iPagosService)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)iPagosService)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (iPagosService != null)
      ((javax.xml.rpc.Stub)iPagosService)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.tempuri.IPagosService getIPagosService() {
    if (iPagosService == null)
      _initIPagosServiceProxy();
    return iPagosService;
  }
  
  public org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago[] listarTipoPago() throws java.rmi.RemoteException{
    if (iPagosService == null)
      _initIPagosServiceProxy();
    return iPagosService.listarTipoPago();
  }
  
  public org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje registrarTipoPago(java.lang.String descripcion) throws java.rmi.RemoteException{
    if (iPagosService == null)
      _initIPagosServiceProxy();
    return iPagosService.registrarTipoPago(descripcion);
  }
  
  public org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje registrarCuota(java.lang.String pPeriodo, java.lang.Integer pIdVivienda, java.lang.Integer pIdTipoPago, java.math.BigDecimal pImporte, java.util.Calendar pFecVncto) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje{
    if (iPagosService == null)
      _initIPagosServiceProxy();
    return iPagosService.registrarCuota(pPeriodo, pIdVivienda, pIdTipoPago, pImporte, pFecVncto);
  }
  
  public org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje actualizarCuota(java.lang.Integer pIdCuota, java.lang.String pPeriodo, java.lang.Integer pIdVivienda, java.lang.Integer pIdTipoPago, java.math.BigDecimal pImporte, java.util.Calendar pFecVncto) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje{
    if (iPagosService == null)
      _initIPagosServiceProxy();
    return iPagosService.actualizarCuota(pIdCuota, pPeriodo, pIdVivienda, pIdTipoPago, pImporte, pFecVncto);
  }
  
  public org.datacontract.schemas._2004._07.Architecs_PagosService.Cuota[] listarCuota(java.lang.String pPeriodo) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje{
    if (iPagosService == null)
      _initIPagosServiceProxy();
    return iPagosService.listarCuota(pPeriodo);
  }
  
  public org.datacontract.schemas._2004._07.Architecs_PagosService.Cuota buscarCuota(java.lang.Integer pIdCuota) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje{
    if (iPagosService == null)
      _initIPagosServiceProxy();
    return iPagosService.buscarCuota(pIdCuota);
  }
  
  public org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje eliminarCuota(java.lang.Integer pIdCuota) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.Architecs_Dominio.RetornaMensaje{
    if (iPagosService == null)
      _initIPagosServiceProxy();
    return iPagosService.eliminarCuota(pIdCuota);
  }
  
  
}