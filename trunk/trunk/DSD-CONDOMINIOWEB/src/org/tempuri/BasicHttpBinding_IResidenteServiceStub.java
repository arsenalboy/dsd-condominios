/**
 * BasicHttpBinding_IResidenteServiceStub.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class BasicHttpBinding_IResidenteServiceStub extends org.apache.axis.client.Stub implements org.tempuri.IResidenteService {
    private java.util.Vector cachedSerClasses = new java.util.Vector();
    private java.util.Vector cachedSerQNames = new java.util.Vector();
    private java.util.Vector cachedSerFactories = new java.util.Vector();
    private java.util.Vector cachedDeserFactories = new java.util.Vector();

    static org.apache.axis.description.OperationDesc [] _operations;

    static {
        _operations = new org.apache.axis.description.OperationDesc[7];
        _initOperationDesc1();
    }

    private static void _initOperationDesc1(){
        org.apache.axis.description.OperationDesc oper;
        org.apache.axis.description.ParameterDesc param;
        oper = new org.apache.axis.description.OperationDesc();
        oper.setName("ListarResidentes");
        oper.setReturnType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ArrayOfResidenteBE"));
        oper.setReturnClass(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[].class);
        oper.setReturnQName(new javax.xml.namespace.QName("http://tempuri.org/", "ListarResidentesResult"));
        param = oper.getReturnParamDesc();
        param.setItemQName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE"));
        oper.setStyle(org.apache.axis.constants.Style.WRAPPED);
        oper.setUse(org.apache.axis.constants.Use.LITERAL);
        oper.addFault(new org.apache.axis.description.FaultDesc(
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"),
                      "org.datacontract.schemas._2004._07.ResidenteService.ValidationException",
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"), 
                      true
                     ));
        _operations[0] = oper;

        oper = new org.apache.axis.description.OperationDesc();
        oper.setName("BuscarResidentes");
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "nombre"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false);
        param.setOmittable(true);
        param.setNillable(true);
        oper.addParameter(param);
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "apellidos"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false);
        param.setOmittable(true);
        param.setNillable(true);
        oper.addParameter(param);
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "numDocumento"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"), java.lang.String.class, false, false);
        param.setOmittable(true);
        param.setNillable(true);
        oper.addParameter(param);
        oper.setReturnType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ArrayOfResidenteBE"));
        oper.setReturnClass(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[].class);
        oper.setReturnQName(new javax.xml.namespace.QName("http://tempuri.org/", "BuscarResidentesResult"));
        param = oper.getReturnParamDesc();
        param.setItemQName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE"));
        oper.setStyle(org.apache.axis.constants.Style.WRAPPED);
        oper.setUse(org.apache.axis.constants.Use.LITERAL);
        oper.addFault(new org.apache.axis.description.FaultDesc(
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"),
                      "org.datacontract.schemas._2004._07.ResidenteService.ValidationException",
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"), 
                      true
                     ));
        _operations[1] = oper;

        oper = new org.apache.axis.description.OperationDesc();
        oper.setName("ListarResidentesPaginado");
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "page"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), java.lang.Integer.class, false, false);
        param.setOmittable(true);
        oper.addParameter(param);
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "size"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), java.lang.Integer.class, false, false);
        param.setOmittable(true);
        oper.addParameter(param);
        oper.setReturnType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ArrayOfResidenteBE"));
        oper.setReturnClass(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[].class);
        oper.setReturnQName(new javax.xml.namespace.QName("http://tempuri.org/", "ListarResidentesPaginadoResult"));
        param = oper.getReturnParamDesc();
        param.setItemQName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE"));
        oper.setStyle(org.apache.axis.constants.Style.WRAPPED);
        oper.setUse(org.apache.axis.constants.Use.LITERAL);
        oper.addFault(new org.apache.axis.description.FaultDesc(
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"),
                      "org.datacontract.schemas._2004._07.ResidenteService.ValidationException",
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"), 
                      true
                     ));
        _operations[2] = oper;

        oper = new org.apache.axis.description.OperationDesc();
        oper.setName("ObtenerResidentePorID");
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "residenteId"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), java.lang.Integer.class, false, false);
        param.setOmittable(true);
        oper.addParameter(param);
        oper.setReturnType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE"));
        oper.setReturnClass(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE.class);
        oper.setReturnQName(new javax.xml.namespace.QName("http://tempuri.org/", "ObtenerResidentePorIDResult"));
        oper.setStyle(org.apache.axis.constants.Style.WRAPPED);
        oper.setUse(org.apache.axis.constants.Use.LITERAL);
        oper.addFault(new org.apache.axis.description.FaultDesc(
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"),
                      "org.datacontract.schemas._2004._07.ResidenteService.ValidationException",
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"), 
                      true
                     ));
        _operations[3] = oper;

        oper = new org.apache.axis.description.OperationDesc();
        oper.setName("CrearResidente");
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "prmResidente"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE"), org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE.class, false, false);
        param.setOmittable(true);
        param.setNillable(true);
        oper.addParameter(param);
        oper.setReturnType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        oper.setReturnClass(java.lang.Integer.class);
        oper.setReturnQName(new javax.xml.namespace.QName("http://tempuri.org/", "CrearResidenteResult"));
        oper.setStyle(org.apache.axis.constants.Style.WRAPPED);
        oper.setUse(org.apache.axis.constants.Use.LITERAL);
        oper.addFault(new org.apache.axis.description.FaultDesc(
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"),
                      "org.datacontract.schemas._2004._07.ResidenteService.ValidationException",
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"), 
                      true
                     ));
        _operations[4] = oper;

        oper = new org.apache.axis.description.OperationDesc();
        oper.setName("ActualizarResidente");
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "prmResidente"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE"), org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE.class, false, false);
        param.setOmittable(true);
        param.setNillable(true);
        oper.addParameter(param);
        oper.setReturnType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"));
        oper.setReturnClass(org.datacontract.schemas._2004._07.ResidenteService.ValidationException.class);
        oper.setReturnQName(new javax.xml.namespace.QName("http://tempuri.org/", "ActualizarResidenteResult"));
        oper.setStyle(org.apache.axis.constants.Style.WRAPPED);
        oper.setUse(org.apache.axis.constants.Use.LITERAL);
        oper.addFault(new org.apache.axis.description.FaultDesc(
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"),
                      "org.datacontract.schemas._2004._07.ResidenteService.ValidationException",
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"), 
                      true
                     ));
        _operations[5] = oper;

        oper = new org.apache.axis.description.OperationDesc();
        oper.setName("EliminarResidente");
        param = new org.apache.axis.description.ParameterDesc(new javax.xml.namespace.QName("http://tempuri.org/", "residenteID"), org.apache.axis.description.ParameterDesc.IN, new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"), java.lang.Integer.class, false, false);
        param.setOmittable(true);
        oper.addParameter(param);
        oper.setReturnType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"));
        oper.setReturnClass(org.datacontract.schemas._2004._07.ResidenteService.ValidationException.class);
        oper.setReturnQName(new javax.xml.namespace.QName("http://tempuri.org/", "EliminarResidenteResult"));
        oper.setStyle(org.apache.axis.constants.Style.WRAPPED);
        oper.setUse(org.apache.axis.constants.Use.LITERAL);
        oper.addFault(new org.apache.axis.description.FaultDesc(
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"),
                      "org.datacontract.schemas._2004._07.ResidenteService.ValidationException",
                      new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException"), 
                      true
                     ));
        _operations[6] = oper;

    }

    public BasicHttpBinding_IResidenteServiceStub() throws org.apache.axis.AxisFault {
         this(null);
    }

    public BasicHttpBinding_IResidenteServiceStub(java.net.URL endpointURL, javax.xml.rpc.Service service) throws org.apache.axis.AxisFault {
         this(service);
         super.cachedEndpoint = endpointURL;
    }

    public BasicHttpBinding_IResidenteServiceStub(javax.xml.rpc.Service service) throws org.apache.axis.AxisFault {
        if (service == null) {
            super.service = new org.apache.axis.client.Service();
        } else {
            super.service = service;
        }
        ((org.apache.axis.client.Service)super.service).setTypeMappingVersion("1.2");
            java.lang.Class cls;
            javax.xml.namespace.QName qName;
            javax.xml.namespace.QName qName2;
            java.lang.Class beansf = org.apache.axis.encoding.ser.BeanSerializerFactory.class;
            java.lang.Class beandf = org.apache.axis.encoding.ser.BeanDeserializerFactory.class;
            java.lang.Class enumsf = org.apache.axis.encoding.ser.EnumSerializerFactory.class;
            java.lang.Class enumdf = org.apache.axis.encoding.ser.EnumDeserializerFactory.class;
            java.lang.Class arraysf = org.apache.axis.encoding.ser.ArraySerializerFactory.class;
            java.lang.Class arraydf = org.apache.axis.encoding.ser.ArrayDeserializerFactory.class;
            java.lang.Class simplesf = org.apache.axis.encoding.ser.SimpleSerializerFactory.class;
            java.lang.Class simpledf = org.apache.axis.encoding.ser.SimpleDeserializerFactory.class;
            java.lang.Class simplelistsf = org.apache.axis.encoding.ser.SimpleListSerializerFactory.class;
            java.lang.Class simplelistdf = org.apache.axis.encoding.ser.SimpleListDeserializerFactory.class;
            qName = new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ArrayOfResidenteBE");
            cachedSerQNames.add(qName);
            cls = org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[].class;
            cachedSerClasses.add(cls);
            qName = new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE");
            qName2 = new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE");
            cachedSerFactories.add(new org.apache.axis.encoding.ser.ArraySerializerFactory(qName, qName2));
            cachedDeserFactories.add(new org.apache.axis.encoding.ser.ArrayDeserializerFactory());

            qName = new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE");
            cachedSerQNames.add(qName);
            cls = org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE.class;
            cachedSerClasses.add(cls);
            cachedSerFactories.add(beansf);
            cachedDeserFactories.add(beandf);

            qName = new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/ResidenteService", "ValidationException");
            cachedSerQNames.add(qName);
            cls = org.datacontract.schemas._2004._07.ResidenteService.ValidationException.class;
            cachedSerClasses.add(cls);
            cachedSerFactories.add(beansf);
            cachedDeserFactories.add(beandf);

    }

    protected org.apache.axis.client.Call createCall() throws java.rmi.RemoteException {
        try {
            org.apache.axis.client.Call _call = super._createCall();
            if (super.maintainSessionSet) {
                _call.setMaintainSession(super.maintainSession);
            }
            if (super.cachedUsername != null) {
                _call.setUsername(super.cachedUsername);
            }
            if (super.cachedPassword != null) {
                _call.setPassword(super.cachedPassword);
            }
            if (super.cachedEndpoint != null) {
                _call.setTargetEndpointAddress(super.cachedEndpoint);
            }
            if (super.cachedTimeout != null) {
                _call.setTimeout(super.cachedTimeout);
            }
            if (super.cachedPortName != null) {
                _call.setPortName(super.cachedPortName);
            }
            java.util.Enumeration keys = super.cachedProperties.keys();
            while (keys.hasMoreElements()) {
                java.lang.String key = (java.lang.String) keys.nextElement();
                _call.setProperty(key, super.cachedProperties.get(key));
            }
            // All the type mapping information is registered
            // when the first call is made.
            // The type mapping information is actually registered in
            // the TypeMappingRegistry of the service, which
            // is the reason why registration is only needed for the first call.
            synchronized (this) {
                if (firstCall()) {
                    // must set encoding style before registering serializers
                    _call.setEncodingStyle(null);
                    for (int i = 0; i < cachedSerFactories.size(); ++i) {
                        java.lang.Class cls = (java.lang.Class) cachedSerClasses.get(i);
                        javax.xml.namespace.QName qName =
                                (javax.xml.namespace.QName) cachedSerQNames.get(i);
                        java.lang.Object x = cachedSerFactories.get(i);
                        if (x instanceof Class) {
                            java.lang.Class sf = (java.lang.Class)
                                 cachedSerFactories.get(i);
                            java.lang.Class df = (java.lang.Class)
                                 cachedDeserFactories.get(i);
                            _call.registerTypeMapping(cls, qName, sf, df, false);
                        }
                        else if (x instanceof javax.xml.rpc.encoding.SerializerFactory) {
                            org.apache.axis.encoding.SerializerFactory sf = (org.apache.axis.encoding.SerializerFactory)
                                 cachedSerFactories.get(i);
                            org.apache.axis.encoding.DeserializerFactory df = (org.apache.axis.encoding.DeserializerFactory)
                                 cachedDeserFactories.get(i);
                            _call.registerTypeMapping(cls, qName, sf, df, false);
                        }
                    }
                }
            }
            return _call;
        }
        catch (java.lang.Throwable _t) {
            throw new org.apache.axis.AxisFault("Failure trying to get the Call object", _t);
        }
    }

    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] listarResidentes() throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException {
        if (super.cachedEndpoint == null) {
            throw new org.apache.axis.NoEndPointException();
        }
        org.apache.axis.client.Call _call = createCall();
        _call.setOperation(_operations[0]);
        _call.setUseSOAPAction(true);
        _call.setSOAPActionURI("http://tempuri.org/IResidenteService/ListarResidentes");
        _call.setEncodingStyle(null);
        _call.setProperty(org.apache.axis.client.Call.SEND_TYPE_ATTR, Boolean.FALSE);
        _call.setProperty(org.apache.axis.AxisEngine.PROP_DOMULTIREFS, Boolean.FALSE);
        _call.setSOAPVersion(org.apache.axis.soap.SOAPConstants.SOAP11_CONSTANTS);
        _call.setOperationName(new javax.xml.namespace.QName("http://tempuri.org/", "ListarResidentes"));

        setRequestHeaders(_call);
        setAttachments(_call);
 try {        java.lang.Object _resp = _call.invoke(new java.lang.Object[] {});

        if (_resp instanceof java.rmi.RemoteException) {
            throw (java.rmi.RemoteException)_resp;
        }
        else {
            extractAttachments(_call);
            try {
                return (org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[]) _resp;
            } catch (java.lang.Exception _exception) {
                return (org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[]) org.apache.axis.utils.JavaUtils.convert(_resp, org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[].class);
            }
        }
  } catch (org.apache.axis.AxisFault axisFaultException) {
    if (axisFaultException.detail != null) {
        if (axisFaultException.detail instanceof java.rmi.RemoteException) {
              throw (java.rmi.RemoteException) axisFaultException.detail;
         }
        if (axisFaultException.detail instanceof org.datacontract.schemas._2004._07.ResidenteService.ValidationException) {
              throw (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) axisFaultException.detail;
         }
   }
  throw axisFaultException;
}
    }

    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] buscarResidentes(java.lang.String nombre, java.lang.String apellidos, java.lang.String numDocumento) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException {
        if (super.cachedEndpoint == null) {
            throw new org.apache.axis.NoEndPointException();
        }
        org.apache.axis.client.Call _call = createCall();
        _call.setOperation(_operations[1]);
        _call.setUseSOAPAction(true);
        _call.setSOAPActionURI("http://tempuri.org/IResidenteService/BuscarResidentes");
        _call.setEncodingStyle(null);
        _call.setProperty(org.apache.axis.client.Call.SEND_TYPE_ATTR, Boolean.FALSE);
        _call.setProperty(org.apache.axis.AxisEngine.PROP_DOMULTIREFS, Boolean.FALSE);
        _call.setSOAPVersion(org.apache.axis.soap.SOAPConstants.SOAP11_CONSTANTS);
        _call.setOperationName(new javax.xml.namespace.QName("http://tempuri.org/", "BuscarResidentes"));

        setRequestHeaders(_call);
        setAttachments(_call);
 try {        java.lang.Object _resp = _call.invoke(new java.lang.Object[] {nombre, apellidos, numDocumento});

        if (_resp instanceof java.rmi.RemoteException) {
            throw (java.rmi.RemoteException)_resp;
        }
        else {
            extractAttachments(_call);
            try {
                return (org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[]) _resp;
            } catch (java.lang.Exception _exception) {
                return (org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[]) org.apache.axis.utils.JavaUtils.convert(_resp, org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[].class);
            }
        }
  } catch (org.apache.axis.AxisFault axisFaultException) {
    if (axisFaultException.detail != null) {
        if (axisFaultException.detail instanceof java.rmi.RemoteException) {
              throw (java.rmi.RemoteException) axisFaultException.detail;
         }
        if (axisFaultException.detail instanceof org.datacontract.schemas._2004._07.ResidenteService.ValidationException) {
              throw (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) axisFaultException.detail;
         }
   }
  throw axisFaultException;
}
    }

    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[] listarResidentesPaginado(java.lang.Integer page, java.lang.Integer size) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException {
        if (super.cachedEndpoint == null) {
            throw new org.apache.axis.NoEndPointException();
        }
        org.apache.axis.client.Call _call = createCall();
        _call.setOperation(_operations[2]);
        _call.setUseSOAPAction(true);
        _call.setSOAPActionURI("http://tempuri.org/IResidenteService/ListarResidentesPaginado");
        _call.setEncodingStyle(null);
        _call.setProperty(org.apache.axis.client.Call.SEND_TYPE_ATTR, Boolean.FALSE);
        _call.setProperty(org.apache.axis.AxisEngine.PROP_DOMULTIREFS, Boolean.FALSE);
        _call.setSOAPVersion(org.apache.axis.soap.SOAPConstants.SOAP11_CONSTANTS);
        _call.setOperationName(new javax.xml.namespace.QName("http://tempuri.org/", "ListarResidentesPaginado"));

        setRequestHeaders(_call);
        setAttachments(_call);
 try {        java.lang.Object _resp = _call.invoke(new java.lang.Object[] {page, size});

        if (_resp instanceof java.rmi.RemoteException) {
            throw (java.rmi.RemoteException)_resp;
        }
        else {
            extractAttachments(_call);
            try {
                return (org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[]) _resp;
            } catch (java.lang.Exception _exception) {
                return (org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[]) org.apache.axis.utils.JavaUtils.convert(_resp, org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE[].class);
            }
        }
  } catch (org.apache.axis.AxisFault axisFaultException) {
    if (axisFaultException.detail != null) {
        if (axisFaultException.detail instanceof java.rmi.RemoteException) {
              throw (java.rmi.RemoteException) axisFaultException.detail;
         }
        if (axisFaultException.detail instanceof org.datacontract.schemas._2004._07.ResidenteService.ValidationException) {
              throw (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) axisFaultException.detail;
         }
   }
  throw axisFaultException;
}
    }

    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE obtenerResidentePorID(java.lang.Integer residenteId) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException {
        if (super.cachedEndpoint == null) {
            throw new org.apache.axis.NoEndPointException();
        }
        org.apache.axis.client.Call _call = createCall();
        _call.setOperation(_operations[3]);
        _call.setUseSOAPAction(true);
        _call.setSOAPActionURI("http://tempuri.org/IResidenteService/ObtenerResidentePorID");
        _call.setEncodingStyle(null);
        _call.setProperty(org.apache.axis.client.Call.SEND_TYPE_ATTR, Boolean.FALSE);
        _call.setProperty(org.apache.axis.AxisEngine.PROP_DOMULTIREFS, Boolean.FALSE);
        _call.setSOAPVersion(org.apache.axis.soap.SOAPConstants.SOAP11_CONSTANTS);
        _call.setOperationName(new javax.xml.namespace.QName("http://tempuri.org/", "ObtenerResidentePorID"));

        setRequestHeaders(_call);
        setAttachments(_call);
 try {        java.lang.Object _resp = _call.invoke(new java.lang.Object[] {residenteId});

        if (_resp instanceof java.rmi.RemoteException) {
            throw (java.rmi.RemoteException)_resp;
        }
        else {
            extractAttachments(_call);
            try {
                return (org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE) _resp;
            } catch (java.lang.Exception _exception) {
                return (org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE) org.apache.axis.utils.JavaUtils.convert(_resp, org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE.class);
            }
        }
  } catch (org.apache.axis.AxisFault axisFaultException) {
    if (axisFaultException.detail != null) {
        if (axisFaultException.detail instanceof java.rmi.RemoteException) {
              throw (java.rmi.RemoteException) axisFaultException.detail;
         }
        if (axisFaultException.detail instanceof org.datacontract.schemas._2004._07.ResidenteService.ValidationException) {
              throw (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) axisFaultException.detail;
         }
   }
  throw axisFaultException;
}
    }

    public java.lang.Integer crearResidente(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE prmResidente) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException {
        if (super.cachedEndpoint == null) {
            throw new org.apache.axis.NoEndPointException();
        }
        org.apache.axis.client.Call _call = createCall();
        _call.setOperation(_operations[4]);
        _call.setUseSOAPAction(true);
        _call.setSOAPActionURI("http://tempuri.org/IResidenteService/CrearResidente");
        _call.setEncodingStyle(null);
        _call.setProperty(org.apache.axis.client.Call.SEND_TYPE_ATTR, Boolean.FALSE);
        _call.setProperty(org.apache.axis.AxisEngine.PROP_DOMULTIREFS, Boolean.FALSE);
        _call.setSOAPVersion(org.apache.axis.soap.SOAPConstants.SOAP11_CONSTANTS);
        _call.setOperationName(new javax.xml.namespace.QName("http://tempuri.org/", "CrearResidente"));

        setRequestHeaders(_call);
        setAttachments(_call);
 try {        java.lang.Object _resp = _call.invoke(new java.lang.Object[] {prmResidente});

        if (_resp instanceof java.rmi.RemoteException) {
            throw (java.rmi.RemoteException)_resp;
        }
        else {
            extractAttachments(_call);
            try {
                return (java.lang.Integer) _resp;
            } catch (java.lang.Exception _exception) {
                return (java.lang.Integer) org.apache.axis.utils.JavaUtils.convert(_resp, java.lang.Integer.class);
            }
        }
  } catch (org.apache.axis.AxisFault axisFaultException) {
    if (axisFaultException.detail != null) {
        if (axisFaultException.detail instanceof java.rmi.RemoteException) {
              throw (java.rmi.RemoteException) axisFaultException.detail;
         }
        if (axisFaultException.detail instanceof org.datacontract.schemas._2004._07.ResidenteService.ValidationException) {
              throw (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) axisFaultException.detail;
         }
   }
  throw axisFaultException;
}
    }

    public org.datacontract.schemas._2004._07.ResidenteService.ValidationException actualizarResidente(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE prmResidente) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException {
        if (super.cachedEndpoint == null) {
            throw new org.apache.axis.NoEndPointException();
        }
        org.apache.axis.client.Call _call = createCall();
        _call.setOperation(_operations[5]);
        _call.setUseSOAPAction(true);
        _call.setSOAPActionURI("http://tempuri.org/IResidenteService/ActualizarResidente");
        _call.setEncodingStyle(null);
        _call.setProperty(org.apache.axis.client.Call.SEND_TYPE_ATTR, Boolean.FALSE);
        _call.setProperty(org.apache.axis.AxisEngine.PROP_DOMULTIREFS, Boolean.FALSE);
        _call.setSOAPVersion(org.apache.axis.soap.SOAPConstants.SOAP11_CONSTANTS);
        _call.setOperationName(new javax.xml.namespace.QName("http://tempuri.org/", "ActualizarResidente"));

        setRequestHeaders(_call);
        setAttachments(_call);
 try {        java.lang.Object _resp = _call.invoke(new java.lang.Object[] {prmResidente});

        if (_resp instanceof java.rmi.RemoteException) {
            throw (java.rmi.RemoteException)_resp;
        }
        else {
            extractAttachments(_call);
            try {
                return (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) _resp;
            } catch (java.lang.Exception _exception) {
                return (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) org.apache.axis.utils.JavaUtils.convert(_resp, org.datacontract.schemas._2004._07.ResidenteService.ValidationException.class);
            }
        }
  } catch (org.apache.axis.AxisFault axisFaultException) {
    if (axisFaultException.detail != null) {
        if (axisFaultException.detail instanceof java.rmi.RemoteException) {
              throw (java.rmi.RemoteException) axisFaultException.detail;
         }
        if (axisFaultException.detail instanceof org.datacontract.schemas._2004._07.ResidenteService.ValidationException) {
              throw (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) axisFaultException.detail;
         }
   }
  throw axisFaultException;
}
    }

    public org.datacontract.schemas._2004._07.ResidenteService.ValidationException eliminarResidente(java.lang.Integer residenteID) throws java.rmi.RemoteException, org.datacontract.schemas._2004._07.ResidenteService.ValidationException {
        if (super.cachedEndpoint == null) {
            throw new org.apache.axis.NoEndPointException();
        }
        org.apache.axis.client.Call _call = createCall();
        _call.setOperation(_operations[6]);
        _call.setUseSOAPAction(true);
        _call.setSOAPActionURI("http://tempuri.org/IResidenteService/EliminarResidente");
        _call.setEncodingStyle(null);
        _call.setProperty(org.apache.axis.client.Call.SEND_TYPE_ATTR, Boolean.FALSE);
        _call.setProperty(org.apache.axis.AxisEngine.PROP_DOMULTIREFS, Boolean.FALSE);
        _call.setSOAPVersion(org.apache.axis.soap.SOAPConstants.SOAP11_CONSTANTS);
        _call.setOperationName(new javax.xml.namespace.QName("http://tempuri.org/", "EliminarResidente"));

        setRequestHeaders(_call);
        setAttachments(_call);
 try {        java.lang.Object _resp = _call.invoke(new java.lang.Object[] {residenteID});

        if (_resp instanceof java.rmi.RemoteException) {
            throw (java.rmi.RemoteException)_resp;
        }
        else {
            extractAttachments(_call);
            try {
                return (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) _resp;
            } catch (java.lang.Exception _exception) {
                return (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) org.apache.axis.utils.JavaUtils.convert(_resp, org.datacontract.schemas._2004._07.ResidenteService.ValidationException.class);
            }
        }
  } catch (org.apache.axis.AxisFault axisFaultException) {
    if (axisFaultException.detail != null) {
        if (axisFaultException.detail instanceof java.rmi.RemoteException) {
              throw (java.rmi.RemoteException) axisFaultException.detail;
         }
        if (axisFaultException.detail instanceof org.datacontract.schemas._2004._07.ResidenteService.ValidationException) {
              throw (org.datacontract.schemas._2004._07.ResidenteService.ValidationException) axisFaultException.detail;
         }
   }
  throw axisFaultException;
}
    }

}
