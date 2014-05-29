/**
 * RetornaMensaje.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.Architecs_Dominio;

public class RetornaMensaje  extends org.apache.axis.AxisFault  implements java.io.Serializable {
    private java.lang.String codigoError;

    private java.lang.Integer codigoRetorno;

    private java.lang.Boolean exito;

    private java.lang.String mensage;

    public RetornaMensaje() {
    }

    public RetornaMensaje(
           java.lang.String codigoError,
           java.lang.Integer codigoRetorno,
           java.lang.Boolean exito,
           java.lang.String mensage) {
        this.codigoError = codigoError;
        this.codigoRetorno = codigoRetorno;
        this.exito = exito;
        this.mensage = mensage;
    }


    /**
     * Gets the codigoError value for this RetornaMensaje.
     * 
     * @return codigoError
     */
    public java.lang.String getCodigoError() {
        return codigoError;
    }


    /**
     * Sets the codigoError value for this RetornaMensaje.
     * 
     * @param codigoError
     */
    public void setCodigoError(java.lang.String codigoError) {
        this.codigoError = codigoError;
    }


    /**
     * Gets the codigoRetorno value for this RetornaMensaje.
     * 
     * @return codigoRetorno
     */
    public java.lang.Integer getCodigoRetorno() {
        return codigoRetorno;
    }


    /**
     * Sets the codigoRetorno value for this RetornaMensaje.
     * 
     * @param codigoRetorno
     */
    public void setCodigoRetorno(java.lang.Integer codigoRetorno) {
        this.codigoRetorno = codigoRetorno;
    }


    /**
     * Gets the exito value for this RetornaMensaje.
     * 
     * @return exito
     */
    public java.lang.Boolean getExito() {
        return exito;
    }


    /**
     * Sets the exito value for this RetornaMensaje.
     * 
     * @param exito
     */
    public void setExito(java.lang.Boolean exito) {
        this.exito = exito;
    }


    /**
     * Gets the mensage value for this RetornaMensaje.
     * 
     * @return mensage
     */
    public java.lang.String getMensage() {
        return mensage;
    }


    /**
     * Sets the mensage value for this RetornaMensaje.
     * 
     * @param mensage
     */
    public void setMensage(java.lang.String mensage) {
        this.mensage = mensage;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof RetornaMensaje)) return false;
        RetornaMensaje other = (RetornaMensaje) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.codigoError==null && other.getCodigoError()==null) || 
             (this.codigoError!=null &&
              this.codigoError.equals(other.getCodigoError()))) &&
            ((this.codigoRetorno==null && other.getCodigoRetorno()==null) || 
             (this.codigoRetorno!=null &&
              this.codigoRetorno.equals(other.getCodigoRetorno()))) &&
            ((this.exito==null && other.getExito()==null) || 
             (this.exito!=null &&
              this.exito.equals(other.getExito()))) &&
            ((this.mensage==null && other.getMensage()==null) || 
             (this.mensage!=null &&
              this.mensage.equals(other.getMensage())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getCodigoError() != null) {
            _hashCode += getCodigoError().hashCode();
        }
        if (getCodigoRetorno() != null) {
            _hashCode += getCodigoRetorno().hashCode();
        }
        if (getExito() != null) {
            _hashCode += getExito().hashCode();
        }
        if (getMensage() != null) {
            _hashCode += getMensage().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(RetornaMensaje.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "RetornaMensaje"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("codigoError");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "CodigoError"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("codigoRetorno");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "CodigoRetorno"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("exito");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "Exito"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("mensage");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "Mensage"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }


    /**
     * Writes the exception data to the faultDetails
     */
    public void writeDetails(javax.xml.namespace.QName qname, org.apache.axis.encoding.SerializationContext context) throws java.io.IOException {
        context.serialize(qname, null, this);
    }
}
