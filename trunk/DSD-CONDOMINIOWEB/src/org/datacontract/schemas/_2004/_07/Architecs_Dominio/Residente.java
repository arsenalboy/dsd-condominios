/**
 * Residente.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.datacontract.schemas._2004._07.Architecs_Dominio;

public class Residente  implements java.io.Serializable {
    private java.lang.Boolean b_Estado;

    private java.lang.String c_Apellidos;

    private java.lang.String c_Clave;

    private java.lang.String c_Correo;

    private java.lang.String c_Nombre;

    private java.lang.String c_NumDocume;

    private java.util.Calendar d_FecNacimi;

    private java.lang.Integer n_IdResidente;

    private java.lang.Integer n_TipoDoc;

    public Residente() {
    }

    public Residente(
           java.lang.Boolean b_Estado,
           java.lang.String c_Apellidos,
           java.lang.String c_Clave,
           java.lang.String c_Correo,
           java.lang.String c_Nombre,
           java.lang.String c_NumDocume,
           java.util.Calendar d_FecNacimi,
           java.lang.Integer n_IdResidente,
           java.lang.Integer n_TipoDoc) {
           this.b_Estado = b_Estado;
           this.c_Apellidos = c_Apellidos;
           this.c_Clave = c_Clave;
           this.c_Correo = c_Correo;
           this.c_Nombre = c_Nombre;
           this.c_NumDocume = c_NumDocume;
           this.d_FecNacimi = d_FecNacimi;
           this.n_IdResidente = n_IdResidente;
           this.n_TipoDoc = n_TipoDoc;
    }


    /**
     * Gets the b_Estado value for this Residente.
     * 
     * @return b_Estado
     */
    public java.lang.Boolean getB_Estado() {
        return b_Estado;
    }


    /**
     * Sets the b_Estado value for this Residente.
     * 
     * @param b_Estado
     */
    public void setB_Estado(java.lang.Boolean b_Estado) {
        this.b_Estado = b_Estado;
    }


    /**
     * Gets the c_Apellidos value for this Residente.
     * 
     * @return c_Apellidos
     */
    public java.lang.String getC_Apellidos() {
        return c_Apellidos;
    }


    /**
     * Sets the c_Apellidos value for this Residente.
     * 
     * @param c_Apellidos
     */
    public void setC_Apellidos(java.lang.String c_Apellidos) {
        this.c_Apellidos = c_Apellidos;
    }


    /**
     * Gets the c_Clave value for this Residente.
     * 
     * @return c_Clave
     */
    public java.lang.String getC_Clave() {
        return c_Clave;
    }


    /**
     * Sets the c_Clave value for this Residente.
     * 
     * @param c_Clave
     */
    public void setC_Clave(java.lang.String c_Clave) {
        this.c_Clave = c_Clave;
    }


    /**
     * Gets the c_Correo value for this Residente.
     * 
     * @return c_Correo
     */
    public java.lang.String getC_Correo() {
        return c_Correo;
    }


    /**
     * Sets the c_Correo value for this Residente.
     * 
     * @param c_Correo
     */
    public void setC_Correo(java.lang.String c_Correo) {
        this.c_Correo = c_Correo;
    }


    /**
     * Gets the c_Nombre value for this Residente.
     * 
     * @return c_Nombre
     */
    public java.lang.String getC_Nombre() {
        return c_Nombre;
    }


    /**
     * Sets the c_Nombre value for this Residente.
     * 
     * @param c_Nombre
     */
    public void setC_Nombre(java.lang.String c_Nombre) {
        this.c_Nombre = c_Nombre;
    }


    /**
     * Gets the c_NumDocume value for this Residente.
     * 
     * @return c_NumDocume
     */
    public java.lang.String getC_NumDocume() {
        return c_NumDocume;
    }


    /**
     * Sets the c_NumDocume value for this Residente.
     * 
     * @param c_NumDocume
     */
    public void setC_NumDocume(java.lang.String c_NumDocume) {
        this.c_NumDocume = c_NumDocume;
    }


    /**
     * Gets the d_FecNacimi value for this Residente.
     * 
     * @return d_FecNacimi
     */
    public java.util.Calendar getD_FecNacimi() {
        return d_FecNacimi;
    }


    /**
     * Sets the d_FecNacimi value for this Residente.
     * 
     * @param d_FecNacimi
     */
    public void setD_FecNacimi(java.util.Calendar d_FecNacimi) {
        this.d_FecNacimi = d_FecNacimi;
    }


    /**
     * Gets the n_IdResidente value for this Residente.
     * 
     * @return n_IdResidente
     */
    public java.lang.Integer getN_IdResidente() {
        return n_IdResidente;
    }


    /**
     * Sets the n_IdResidente value for this Residente.
     * 
     * @param n_IdResidente
     */
    public void setN_IdResidente(java.lang.Integer n_IdResidente) {
        this.n_IdResidente = n_IdResidente;
    }


    /**
     * Gets the n_TipoDoc value for this Residente.
     * 
     * @return n_TipoDoc
     */
    public java.lang.Integer getN_TipoDoc() {
        return n_TipoDoc;
    }


    /**
     * Sets the n_TipoDoc value for this Residente.
     * 
     * @param n_TipoDoc
     */
    public void setN_TipoDoc(java.lang.Integer n_TipoDoc) {
        this.n_TipoDoc = n_TipoDoc;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof Residente)) return false;
        Residente other = (Residente) obj;
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
            ((this.c_Apellidos==null && other.getC_Apellidos()==null) || 
             (this.c_Apellidos!=null &&
              this.c_Apellidos.equals(other.getC_Apellidos()))) &&
            ((this.c_Clave==null && other.getC_Clave()==null) || 
             (this.c_Clave!=null &&
              this.c_Clave.equals(other.getC_Clave()))) &&
            ((this.c_Correo==null && other.getC_Correo()==null) || 
             (this.c_Correo!=null &&
              this.c_Correo.equals(other.getC_Correo()))) &&
            ((this.c_Nombre==null && other.getC_Nombre()==null) || 
             (this.c_Nombre!=null &&
              this.c_Nombre.equals(other.getC_Nombre()))) &&
            ((this.c_NumDocume==null && other.getC_NumDocume()==null) || 
             (this.c_NumDocume!=null &&
              this.c_NumDocume.equals(other.getC_NumDocume()))) &&
            ((this.d_FecNacimi==null && other.getD_FecNacimi()==null) || 
             (this.d_FecNacimi!=null &&
              this.d_FecNacimi.equals(other.getD_FecNacimi()))) &&
            ((this.n_IdResidente==null && other.getN_IdResidente()==null) || 
             (this.n_IdResidente!=null &&
              this.n_IdResidente.equals(other.getN_IdResidente()))) &&
            ((this.n_TipoDoc==null && other.getN_TipoDoc()==null) || 
             (this.n_TipoDoc!=null &&
              this.n_TipoDoc.equals(other.getN_TipoDoc())));
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
        if (getC_Apellidos() != null) {
            _hashCode += getC_Apellidos().hashCode();
        }
        if (getC_Clave() != null) {
            _hashCode += getC_Clave().hashCode();
        }
        if (getC_Correo() != null) {
            _hashCode += getC_Correo().hashCode();
        }
        if (getC_Nombre() != null) {
            _hashCode += getC_Nombre().hashCode();
        }
        if (getC_NumDocume() != null) {
            _hashCode += getC_NumDocume().hashCode();
        }
        if (getD_FecNacimi() != null) {
            _hashCode += getD_FecNacimi().hashCode();
        }
        if (getN_IdResidente() != null) {
            _hashCode += getN_IdResidente().hashCode();
        }
        if (getN_TipoDoc() != null) {
            _hashCode += getN_TipoDoc().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(Residente.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "Residente"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("b_Estado");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "B_Estado"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "boolean"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_Apellidos");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "C_Apellidos"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_Clave");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "C_Clave"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_Correo");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "C_Correo"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_Nombre");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "C_Nombre"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("c_NumDocume");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "C_NumDocume"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(true);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("d_FecNacimi");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "D_FecNacimi"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_IdResidente");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "N_IdResidente"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("n_TipoDoc");
        elemField.setXmlName(new javax.xml.namespace.QName("http://schemas.datacontract.org/2004/07/Architecs.Dominio", "N_TipoDoc"));
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
