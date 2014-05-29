/**
 * Cuota.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.Architecs_PagosService;

public class Cuota  implements java.io.Serializable {
    private java.lang.String c_Periodo;

    private java.util.Calendar d_FecPago;

    private java.util.Calendar d_FecVncto;

    private java.lang.Integer n_IdCuota;

    private java.lang.Integer n_IdTipoPago;

    private java.lang.Integer n_IdVivienda;

    private java.math.BigDecimal n_Importe;

    private org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago objTipoPago;

    private org.datacontract.schemas._2004._07.Architecs_Dominio.Vivienda objVivienda;

    public Cuota() {
    }

    public Cuota(
           java.lang.String c_Periodo,
           java.util.Calendar d_FecPago,
           java.util.Calendar d_FecVncto,
           java.lang.Integer n_IdCuota,
           java.lang.Integer n_IdTipoPago,
           java.lang.Integer n_IdVivienda,
           java.math.BigDecimal n_Importe,
           org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago objTipoPago,
           org.datacontract.schemas._2004._07.Architecs_Dominio.Vivienda objVivienda) {
           this.c_Periodo = c_Periodo;
           this.d_FecPago = d_FecPago;
           this.d_FecVncto = d_FecVncto;
           this.n_IdCuota = n_IdCuota;
           this.n_IdTipoPago = n_IdTipoPago;
           this.n_IdVivienda = n_IdVivienda;
           this.n_Importe = n_Importe;
           this.objTipoPago = objTipoPago;
           this.objVivienda = objVivienda;
    }


    /**
     * Gets the c_Periodo value for this Cuota.
     * 
     * @return c_Periodo
     */
    public java.lang.String getC_Periodo() {
        return c_Periodo;
    }


    /**
     * Sets the c_Periodo value for this Cuota.
     * 
     * @param c_Periodo
     */
    public void setC_Periodo(java.lang.String c_Periodo) {
        this.c_Periodo = c_Periodo;
    }


    /**
     * Gets the d_FecPago value for this Cuota.
     * 
     * @return d_FecPago
     */
    public java.util.Calendar getD_FecPago() {
        return d_FecPago;
    }


    /**
     * Sets the d_FecPago value for this Cuota.
     * 
     * @param d_FecPago
     */
    public void setD_FecPago(java.util.Calendar d_FecPago) {
        this.d_FecPago = d_FecPago;
    }


    /**
     * Gets the d_FecVncto value for this Cuota.
     * 
     * @return d_FecVncto
     */
    public java.util.Calendar getD_FecVncto() {
        return d_FecVncto;
    }


    /**
     * Sets the d_FecVncto value for this Cuota.
     * 
     * @param d_FecVncto
     */
    public void setD_FecVncto(java.util.Calendar d_FecVncto) {
        this.d_FecVncto = d_FecVncto;
    }


    /**
     * Gets the n_IdCuota value for this Cuota.
     * 
     * @return n_IdCuota
     */
    public java.lang.Integer getN_IdCuota() {
        return n_IdCuota;
    }


    /**
     * Sets the n_IdCuota value for this Cuota.
     * 
     * @param n_IdCuota
     */
    public void setN_IdCuota(java.lang.Integer n_IdCuota) {
        this.n_IdCuota = n_IdCuota;
    }


    /**
     * Gets the n_IdTipoPago value for this Cuota.
     * 
     * @return n_IdTipoPago
     */
    public java.lang.Integer getN_IdTipoPago() {
        return n_IdTipoPago;
    }


    /**
     * Sets the n_IdTipoPago value for this Cuota.
     * 
     * @param n_IdTipoPago
     */
    public void setN_IdTipoPago(java.lang.Integer n_IdTipoPago) {
        this.n_IdTipoPago = n_IdTipoPago;
    }


    /**
     * Gets the n_IdVivienda value for this Cuota.
     * 
     * @return n_IdVivienda
     */
    public java.lang.Integer getN_IdVivienda() {
        return n_IdVivienda;
    }


    /**
     * Sets the n_IdVivienda value for this Cuota.
     * 
     * @param n_IdVivienda
     */
    public void setN_IdVivienda(java.lang.Integer n_IdVivienda) {
        this.n_IdVivienda = n_IdVivienda;
    }


    /**
     * Gets the n_Importe value for this Cuota.
     * 
     * @return n_Importe
     */
    public java.math.BigDecimal getN_Importe() {
        return n_Importe;
    }


    /**
     * Sets the n_Importe value for this Cuota.
     * 
     * @param n_Importe
     */
    public void setN_Importe(java.math.BigDecimal n_Importe) {
        this.n_Importe = n_Importe;
    }


    /**
     * Gets the objTipoPago value for this Cuota.
     * 
     * @return objTipoPago
     */
    public org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago getObjTipoPago() {
        return objTipoPago;
    }


    /**
     * Sets the objTipoPago value for this Cuota.
     * 
     * @param objTipoPago
     */
    public void setObjTipoPago(org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago objTipoPago) {
        this.objTipoPago = objTipoPago;
    }


    /**
     * Gets the objVivienda value for this Cuota.
     * 
     * @return objVivienda
     */
    public org.datacontract.schemas._2004._07.Architecs_Dominio.Vivienda getObjVivienda() {
        return objVivienda;
    }


    /**
     * Sets the objVivienda value for this Cuota.
     * 
     * @param objVivienda
     */
    public void setObjVivienda(org.datacontract.schemas._2004._07.Architecs_Dominio.Vivienda objVivienda) {
        this.objVivienda = objVivienda;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof Cuota)) return false;
        Cuota other = (Cuota) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.c_Periodo==null && other.getC_Periodo()==null) || 
             (this.c_Periodo!=null &&
              this.c_Periodo.equals(other.getC_Periodo()))) &&
            ((this.d_FecPago==null && other.getD_FecPago()==null) || 
             (this.d_FecPago!=null &&
              this.d_FecPago.equals(other.getD_FecPago()))) &&
            ((this.d_FecVncto==null && other.getD_FecVncto()==null) || 
             (this.d_FecVncto!=null &&
              this.d_FecVncto.equals(other.getD_FecVncto()))) &&
            ((this.n_IdCuota==null && other.getN_IdCuota()==null) || 
             (this.n_IdCuota!=null &&
              this.n_IdCuota.equals(other.getN_IdCuota()))) &&
            ((this.n_IdTipoPago==null && other.getN_IdTipoPago()==null) || 
             (this.n_IdTipoPago!=null &&
              this.n_IdTipoPago.equals(other.getN_IdTipoPago()))) &&
            ((this.n_IdVivienda==null && other.getN_IdVivienda()==null) || 
             (this.n_IdVivienda!=null &&
              this.n_IdVivienda.equals(other.getN_IdVivienda()))) &&
            ((this.n_Importe==null && other.getN_Importe()==null) || 
             (this.n_Importe!=null &&
              this.n_Importe.equals(other.getN_Importe()))) &&
            ((this.objTipoPago==null && other.getObjTipoPago()==null) || 
             (this.objTipoPago!=null &&
              this.objTipoPago.equals(other.getObjTipoPago()))) &&
            ((this.objVivienda==null && other.getObjVivienda()==null) || 
             (this.objVivienda!=null &&
              this.objVivienda.equals(other.getObjVivienda())));
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
        if (getC_Periodo() != null) {
            _hashCode += getC_Periodo().hashCode();
        }
        if (getD_FecPago() != null) {
            _hashCode += getD_FecPago().hashCode();
        }
        if (getD_FecVncto() != null) {
            _hashCode += getD_FecVncto().hashCode();
        }
        if (getN_IdCuota() != null) {
            _hashCode += getN_IdCuota().hashCode();
        }
        if (getN_IdTipoPago() != null) {
            _hashCode += getN_IdTipoPago().hashCode();
        }
        if (getN_IdVivienda() != null) {
            _hashCode += getN_IdVivienda().hashCode();
        }
        if (getN_Importe() != null) {
            _hashCode += getN_Importe().hashCode();
        }
        if (getObjTipoPago() != null) {
            _hashCode += getObjTipoPago().hashCode();
        }
        if (getObjVivienda() != null) {
            _hashCode += getObjVivienda().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(Cuota.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "Cuota"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_Periodo");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "C_Periodo"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("d_FecPago");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "D_FecPago"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("d_FecVncto");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "D_FecVncto"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_IdCuota");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "N_IdCuota"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_IdTipoPago");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "N_IdTipoPago"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_IdVivienda");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "N_IdVivienda"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_Importe");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "N_Importe"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "decimal"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("objTipoPago");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "objTipoPago"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "TipoPago"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("objVivienda");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.PagosService", "objVivienda"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "Vivienda"));
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

}
