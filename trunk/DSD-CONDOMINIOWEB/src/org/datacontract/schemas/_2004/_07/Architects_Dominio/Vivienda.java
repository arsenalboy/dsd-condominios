/**
 * Vivienda.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.Architects_Dominio;

public class Vivienda  implements java.io.Serializable {
    private java.lang.Boolean b_Estado;

    private java.lang.String c_CodTipo;

    private java.lang.String c_NumDpto;

    private java.lang.String c_NumEdificio;

    private java.lang.Integer n_IdResidente;

    private java.lang.Integer n_IdVivienda;

    private java.math.BigDecimal n_NumMetros;

    private org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE objResidente;

    public Vivienda() {
    }

    public Vivienda(
           java.lang.Boolean b_Estado,
           java.lang.String c_CodTipo,
           java.lang.String c_NumDpto,
           java.lang.String c_NumEdificio,
           java.lang.Integer n_IdResidente,
           java.lang.Integer n_IdVivienda,
           java.math.BigDecimal n_NumMetros,
           org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE objResidente) {
           this.b_Estado = b_Estado;
           this.c_CodTipo = c_CodTipo;
           this.c_NumDpto = c_NumDpto;
           this.c_NumEdificio = c_NumEdificio;
           this.n_IdResidente = n_IdResidente;
           this.n_IdVivienda = n_IdVivienda;
           this.n_NumMetros = n_NumMetros;
           this.objResidente = objResidente;
    }


    /**
     * Gets the b_Estado value for this Vivienda.
     * 
     * @return b_Estado
     */
    public java.lang.Boolean getB_Estado() {
        return b_Estado;
    }


    /**
     * Sets the b_Estado value for this Vivienda.
     * 
     * @param b_Estado
     */
    public void setB_Estado(java.lang.Boolean b_Estado) {
        this.b_Estado = b_Estado;
    }


    /**
     * Gets the c_CodTipo value for this Vivienda.
     * 
     * @return c_CodTipo
     */
    public java.lang.String getC_CodTipo() {
        return c_CodTipo;
    }


    /**
     * Sets the c_CodTipo value for this Vivienda.
     * 
     * @param c_CodTipo
     */
    public void setC_CodTipo(java.lang.String c_CodTipo) {
        this.c_CodTipo = c_CodTipo;
    }


    /**
     * Gets the c_NumDpto value for this Vivienda.
     * 
     * @return c_NumDpto
     */
    public java.lang.String getC_NumDpto() {
        return c_NumDpto;
    }


    /**
     * Sets the c_NumDpto value for this Vivienda.
     * 
     * @param c_NumDpto
     */
    public void setC_NumDpto(java.lang.String c_NumDpto) {
        this.c_NumDpto = c_NumDpto;
    }


    /**
     * Gets the c_NumEdificio value for this Vivienda.
     * 
     * @return c_NumEdificio
     */
    public java.lang.String getC_NumEdificio() {
        return c_NumEdificio;
    }


    /**
     * Sets the c_NumEdificio value for this Vivienda.
     * 
     * @param c_NumEdificio
     */
    public void setC_NumEdificio(java.lang.String c_NumEdificio) {
        this.c_NumEdificio = c_NumEdificio;
    }


    /**
     * Gets the n_IdResidente value for this Vivienda.
     * 
     * @return n_IdResidente
     */
    public java.lang.Integer getN_IdResidente() {
        return n_IdResidente;
    }


    /**
     * Sets the n_IdResidente value for this Vivienda.
     * 
     * @param n_IdResidente
     */
    public void setN_IdResidente(java.lang.Integer n_IdResidente) {
        this.n_IdResidente = n_IdResidente;
    }


    /**
     * Gets the n_IdVivienda value for this Vivienda.
     * 
     * @return n_IdVivienda
     */
    public java.lang.Integer getN_IdVivienda() {
        return n_IdVivienda;
    }


    /**
     * Sets the n_IdVivienda value for this Vivienda.
     * 
     * @param n_IdVivienda
     */
    public void setN_IdVivienda(java.lang.Integer n_IdVivienda) {
        this.n_IdVivienda = n_IdVivienda;
    }


    /**
     * Gets the n_NumMetros value for this Vivienda.
     * 
     * @return n_NumMetros
     */
    public java.math.BigDecimal getN_NumMetros() {
        return n_NumMetros;
    }


    /**
     * Sets the n_NumMetros value for this Vivienda.
     * 
     * @param n_NumMetros
     */
    public void setN_NumMetros(java.math.BigDecimal n_NumMetros) {
        this.n_NumMetros = n_NumMetros;
    }


    /**
     * Gets the objResidente value for this Vivienda.
     * 
     * @return objResidente
     */
    public org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE getObjResidente() {
        return objResidente;
    }


    /**
     * Sets the objResidente value for this Vivienda.
     * 
     * @param objResidente
     */
    public void setObjResidente(org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE objResidente) {
        this.objResidente = objResidente;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof Vivienda)) return false;
        Vivienda other = (Vivienda) obj;
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
            ((this.c_CodTipo==null && other.getC_CodTipo()==null) || 
             (this.c_CodTipo!=null &&
              this.c_CodTipo.equals(other.getC_CodTipo()))) &&
            ((this.c_NumDpto==null && other.getC_NumDpto()==null) || 
             (this.c_NumDpto!=null &&
              this.c_NumDpto.equals(other.getC_NumDpto()))) &&
            ((this.c_NumEdificio==null && other.getC_NumEdificio()==null) || 
             (this.c_NumEdificio!=null &&
              this.c_NumEdificio.equals(other.getC_NumEdificio()))) &&
            ((this.n_IdResidente==null && other.getN_IdResidente()==null) || 
             (this.n_IdResidente!=null &&
              this.n_IdResidente.equals(other.getN_IdResidente()))) &&
            ((this.n_IdVivienda==null && other.getN_IdVivienda()==null) || 
             (this.n_IdVivienda!=null &&
              this.n_IdVivienda.equals(other.getN_IdVivienda()))) &&
            ((this.n_NumMetros==null && other.getN_NumMetros()==null) || 
             (this.n_NumMetros!=null &&
              this.n_NumMetros.equals(other.getN_NumMetros()))) &&
            ((this.objResidente==null && other.getObjResidente()==null) || 
             (this.objResidente!=null &&
              this.objResidente.equals(other.getObjResidente())));
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
        if (getC_CodTipo() != null) {
            _hashCode += getC_CodTipo().hashCode();
        }
        if (getC_NumDpto() != null) {
            _hashCode += getC_NumDpto().hashCode();
        }
        if (getC_NumEdificio() != null) {
            _hashCode += getC_NumEdificio().hashCode();
        }
        if (getN_IdResidente() != null) {
            _hashCode += getN_IdResidente().hashCode();
        }
        if (getN_IdVivienda() != null) {
            _hashCode += getN_IdVivienda().hashCode();
        }
        if (getN_NumMetros() != null) {
            _hashCode += getN_NumMetros().hashCode();
        }
        if (getObjResidente() != null) {
            _hashCode += getObjResidente().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(Vivienda.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "Vivienda"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("b_Estado");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "B_Estado"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_CodTipo");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "C_CodTipo"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_NumDpto");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "C_NumDpto"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_NumEdificio");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "C_NumEdificio"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_IdResidente");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "N_IdResidente"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_IdVivienda");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "N_IdVivienda"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_NumMetros");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "N_NumMetros"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "decimal"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("objResidente");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "objResidente"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architects.Dominio", "ResidenteBE"));
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
