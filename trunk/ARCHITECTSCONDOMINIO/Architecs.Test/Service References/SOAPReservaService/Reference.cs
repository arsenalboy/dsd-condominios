﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Architecs.Test.SOAPReservaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReservasBE", Namespace="http://schemas.datacontract.org/2004/07/Architecs.ReservasService.Dominio")]
    [System.SerializableAttribute()]
    public partial class ReservasBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool B_EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime D_FecRegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdEspacioComunField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdHorarioFinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdHorarioIniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdReservaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdResidenteField;
        
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
        public int N_IdEspacioComun {
            get {
                return this.N_IdEspacioComunField;
            }
            set {
                if ((this.N_IdEspacioComunField.Equals(value) != true)) {
                    this.N_IdEspacioComunField = value;
                    this.RaisePropertyChanged("N_IdEspacioComun");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdHorarioFin {
            get {
                return this.N_IdHorarioFinField;
            }
            set {
                if ((this.N_IdHorarioFinField.Equals(value) != true)) {
                    this.N_IdHorarioFinField = value;
                    this.RaisePropertyChanged("N_IdHorarioFin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdHorarioIni {
            get {
                return this.N_IdHorarioIniField;
            }
            set {
                if ((this.N_IdHorarioIniField.Equals(value) != true)) {
                    this.N_IdHorarioIniField = value;
                    this.RaisePropertyChanged("N_IdHorarioIni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdReserva {
            get {
                return this.N_IdReservaField;
            }
            set {
                if ((this.N_IdReservaField.Equals(value) != true)) {
                    this.N_IdReservaField = value;
                    this.RaisePropertyChanged("N_IdReserva");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EspacioComunBE", Namespace="http://schemas.datacontract.org/2004/07/Architecs.ReservasService.Dominio")]
    [System.SerializableAttribute()]
    public partial class EspacioComunBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool B_EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string C_NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int N_IdEspacioComunField;
        
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
        public string C_Nombre {
            get {
                return this.C_NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.C_NombreField, value) != true)) {
                    this.C_NombreField = value;
                    this.RaisePropertyChanged("C_Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int N_IdEspacioComun {
            get {
                return this.N_IdEspacioComunField;
            }
            set {
                if ((this.N_IdEspacioComunField.Equals(value) != true)) {
                    this.N_IdEspacioComunField = value;
                    this.RaisePropertyChanged("N_IdEspacioComun");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPReservaService.IReservaService")]
    public interface IReservaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservaService/CreaReserva", ReplyAction="http://tempuri.org/IReservaService/CreaReservaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IReservaService/CreaReservaStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        Architecs.Test.SOAPReservaService.ReservasBE CreaReserva(Architecs.Test.SOAPReservaService.ReservasBE ObjReserva);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservaService/ListarEspacioComun", ReplyAction="http://tempuri.org/IReservaService/ListarEspacioComunResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IReservaService/ListarEspacioComunStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        System.Collections.Generic.List<Architecs.Test.SOAPReservaService.EspacioComunBE> ListarEspacioComun();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReservaServiceChannel : Architecs.Test.SOAPReservaService.IReservaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReservaServiceClient : System.ServiceModel.ClientBase<Architecs.Test.SOAPReservaService.IReservaService>, Architecs.Test.SOAPReservaService.IReservaService {
        
        public ReservaServiceClient() {
        }
        
        public ReservaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReservaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Architecs.Test.SOAPReservaService.ReservasBE CreaReserva(Architecs.Test.SOAPReservaService.ReservasBE ObjReserva) {
            return base.Channel.CreaReserva(ObjReserva);
        }
        
        public System.Collections.Generic.List<Architecs.Test.SOAPReservaService.EspacioComunBE> ListarEspacioComun() {
            return base.Channel.ListarEspacioComun();
        }
    }
}
