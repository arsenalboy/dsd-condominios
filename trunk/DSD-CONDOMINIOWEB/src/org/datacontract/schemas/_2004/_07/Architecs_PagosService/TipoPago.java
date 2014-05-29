/**
 * TipoPago.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.Architecs_PagosService;

public class TipoPago  implements java.io.Serializable {
    private java.lang.Boolean b_Estado;

    private java.lang.String c_Descripcion;

    private java.lang.Integer n_IdTipoPago;

    public TipoPago() {
    }

    public TipoPago(
           java.lang.Boolean b_Estado,
           java.lang.String c_Descripcion,
           java.lang.Integer n_IdTipoPago) {
           this.b_Estado = b_Estado;
           this.c_Descripcion = c_Descripcion;
           this.n_IdTipoPago = n_IdTipoPago;
    }


    /**
     * Gets the b_Estado value for this TipoPago.
     * 
     * @return b_Estado
     */
    public java.lang.Boolean getB_Estado() {
        return b_Estado;
    }


    /**
     * Sets the b_Estado value for this TipoPago.
     * 
     * @param b_Estado
     */
    public void setB_Estado(java.lang.Boolean b_Estado) {
        this.b_Estado = b_Estado;
    }


    /**
     * Gets the c_Descripcion value for this TipoPago.
     * 
     * @return c_Descripcion
     */
    public java.lang.String getC_Descripcion() {
        return c_Descripcion;
    }


    /**
     * Sets the c_Descripcion value for this TipoPago.
     * 
     * @param c_Descripcion
     */
    public void setC_Descripcion(java.lang.String c_Descripcion) {
        this.c_Descripcion = c_Descripcion;
    }


    /**
     * Gets the n_IdTipoPago value for this TipoPago.
     * 
     * @return n_IdTipoPago
     */
    public java.lang.Integer getN_IdTipoPago() {
        return n_IdTipoPago;
    }


    /**
     * Sets the n_IdTipoPago value for this TipoPago.
     * 
     * @param n_IdTipoPago
     */
    public void setN_IdTipoPago(java.lang.Integer n_IdTipoPago) {
        this.n_IdTipoPago = n_IdTipoPago;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof TipoPago)) return false;
        TipoPago other = (TipoPago) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.b_Estado==null && other.getB_Estado()==null) || 
             (this.b_Estado!=null &&
              this.b_Estado.equals(other.getB_Estado()))) &&
            ((this.c_Descripcion==null && other.getC_Descripcion()==null) || 
             (this.c_Descripcion!=null &&
              this.c_Descripcion.equals(other.getC_Descripcion()))) &&
            ((this.n_IdTipoPago==null && other.getN_IdTipoPago()==null) || 
             (this.n_IdTipoPago!=null &&
              this.n_IdTipoPago.equals(other.getN_IdTipoPago())));
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
        if (getB_Estado() != null) {
            _hashCode += getB_Estado().hashCode();
        }
        if (getC_Descripcion() != null) {
            _hashCode += getC_Descripcion().hashCode();
        }
        if (getN_IdTipoPago() != null) {
            _hashCode += getN_IdTipoPago().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(TipoPago.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "TipoPago"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("b_Estado");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "B_Estado"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_Descripcion");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "C_Descripcion"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_IdTipoPago");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "N_IdTipoPago"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
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

}
