﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Architecs.QuejasService.QuejaServiceMess {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Queja", Namespace="http://schemas.datacontract.org/2004/07/Architecs.QuejasService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Queja : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool B_EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_DetalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_MotivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_TipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string D_FecQuejaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime D_FecRegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdQuejaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdResidenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Architects.Dominio.ResidenteBE ResidenteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool B_Estado {
            get {
                return this.B_EstadoField;
            }
            set {
                if ((this.B_EstadoField.Equals(value) != true)) {
                    this.B_EstadoField = value;
                    this.RaisePropertyChanged("B_Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Detalle {
            get {
                return this.C_DetalleField;
            }
            set {
                if ((object.ReferenceEquals(this.C_DetalleField, value) != true)) {
                    this.C_DetalleField = value;
                    this.RaisePropertyChanged("C_Detalle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Motivo {
            get {
                return this.C_MotivoField;
            }
            set {
                if ((object.ReferenceEquals(this.C_MotivoField, value) != true)) {
                    this.C_MotivoField = value;
                    this.RaisePropertyChanged("C_Motivo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string C_Tipo {
            get {
                return this.C_TipoField;
            }
            set {
                if ((object.ReferenceEquals(this.C_TipoField, value) != true)) {
                    this.C_TipoField = value;
                    this.RaisePropertyChanged("C_Tipo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string D_FecQueja {
            get {
                return this.D_FecQuejaField;
            }
            set {
                if ((object.ReferenceEquals(this.D_FecQuejaField, value) != true)) {
                    this.D_FecQuejaField = value;
                    this.RaisePropertyChanged("D_FecQueja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime D_FecRegistro {
            get {
                return this.D_FecRegistroField;
            }
            set {
                if ((this.D_FecRegistroField.Equals(value) != true)) {
                    this.D_FecRegistroField = value;
                    this.RaisePropertyChanged("D_FecRegistro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdQueja {
            get {
                return this.N_IdQuejaField;
            }
            set {
                if ((this.N_IdQuejaField.Equals(value) != true)) {
                    this.N_IdQuejaField = value;
                    this.RaisePropertyChanged("N_IdQueja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdResidente {
            get {
                return this.N_IdResidenteField;
            }
            set {
                if ((this.N_IdResidenteField.Equals(value) != true)) {
                    this.N_IdResidenteField = value;
                    this.RaisePropertyChanged("N_IdResidente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Architects.Dominio.ResidenteBE Residente {
            get {
                return this.ResidenteField;
            }
            set {
                if ((object.ReferenceEquals(this.ResidenteField, value) != true)) {
                    this.ResidenteField = value;
                    this.RaisePropertyChanged("Residente");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuejaServiceMess.IQuejaServiceMessage")]
    public interface IQuejaServiceMessage {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuejaServiceMessage/CrearQuejaMensaje", ReplyAction="http://tempuri.org/IQuejaServiceMessage/CrearQuejaMensajeResponse")]
        Architecs.QuejasService.QuejaServiceMess.Queja CrearQuejaMensaje(Architecs.QuejasService.QuejaServiceMess.Queja QuejaCrear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuejaServiceMessage/InsertaQuejaEnCola", ReplyAction="http://tempuri.org/IQuejaServiceMessage/InsertaQuejaEnColaResponse")]
        int InsertaQuejaEnCola();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuejaServiceMessageChannel : Architecs.QuejasService.QuejaServiceMess.IQuejaServiceMessage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuejaServiceMessageClient : System.ServiceModel.ClientBase<Architecs.QuejasService.QuejaServiceMess.IQuejaServiceMessage>, Architecs.QuejasService.QuejaServiceMess.IQuejaServiceMessage {
        
        public QuejaServiceMessageClient() {
        }
        
        public QuejaServiceMessageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuejaServiceMessageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuejaServiceMessageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuejaServiceMessageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Architecs.QuejasService.QuejaServiceMess.Queja CrearQuejaMensaje(Architecs.QuejasService.QuejaServiceMess.Queja QuejaCrear) {
            return base.Channel.CrearQuejaMensaje(QuejaCrear);
        }
        
        public int InsertaQuejaEnCola() {
            return base.Channel.InsertaQuejaEnCola();
        }
    }
}
