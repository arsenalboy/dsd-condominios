/**
 * PagosServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class PagosServiceLocator extends org.apache.axis.client.Service implements org.tempuri.PagosService {

    public PagosServiceLocator() {
    }


    public PagosServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public PagosServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for BasicHttpBinding_IPagosService
    private java.lang.String BasicHttpBinding_IPagosService_address = "http://localhost:59154/PagosService.svc";

    public java.lang.String getBasicHttpBinding_IPagosServiceAddress() {
        return BasicHttpBinding_IPagosService_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String BasicHttpBinding_IPagosServiceWSDDServiceName = "BasicHttpBinding_IPagosService";

    public java.lang.String getBasicHttpBinding_IPagosServiceWSDDServiceName() {
        return BasicHttpBinding_IPagosServiceWSDDServiceName;
    }

    public void setBasicHttpBinding_IPagosServiceWSDDServiceName(java.lang.String name) {
        BasicHttpBinding_IPagosServiceWSDDServiceName = name;
    }

    public org.tempuri.IPagosService getBasicHttpBinding_IPagosService() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(BasicHttpBinding_IPagosService_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getBasicHttpBinding_IPagosService(endpoint);
    }

    public org.tempuri.IPagosService getBasicHttpBinding_IPagosService(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.tempuri.BasicHttpBinding_IPagosServiceStub _stub = new org.tempuri.BasicHttpBinding_IPagosServiceStub(portAddress, this);
            _stub.setPortName(getBasicHttpBinding_IPagosServiceWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setBasicHttpBinding_IPagosServiceEndpointAddress(java.lang.String address) {
        BasicHttpBinding_IPagosService_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.tempuri.IPagosService.class.isAssignableFrom(serviceEndpointInterface)) {
                org.tempuri.BasicHttpBinding_IPagosServiceStub _stub = new org.tempuri.BasicHttpBinding_IPagosServiceStub(new java.net.URL(BasicHttpBinding_IPagosService_address), this);
                _stub.setPortName(getBasicHttpBinding_IPagosServiceWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("BasicHttpBinding_IPagosService".equals(inputPortName)) {
            return getBasicHttpBinding_IPagosService();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://tempuri.org/", "PagosService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://tempuri.org/", "BasicHttpBinding_IPagosService"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("BasicHttpBinding_IPagosService".equals(portName)) {
            setBasicHttpBinding_IPagosServiceEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
