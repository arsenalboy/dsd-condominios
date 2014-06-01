﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34014
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.34014.
// 
#pragma warning disable 1591

namespace Architecs.Presentacion.JuntaService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IJuntaService", Namespace="http://tempuri.org/")]
    public partial class JuntaService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback listarDirectivosOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreaJuntaOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreaJuntaDirectivosOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public JuntaService() {
            this.Url = global::Architecs.Presentacion.Properties.Settings.Default.Architecs_Presentacion_JuntaService_JuntaService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event listarDirectivosCompletedEventHandler listarDirectivosCompleted;
        
        /// <remarks/>
        public event CreaJuntaCompletedEventHandler CreaJuntaCompleted;
        
        /// <remarks/>
        public event CreaJuntaDirectivosCompletedEventHandler CreaJuntaDirectivosCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IJuntaService/listarDirectivos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Architecs.ReunionesService.Dominio")]
        public directivo[] listarDirectivos([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string C_NomPer) {
            object[] results = this.Invoke("listarDirectivos", new object[] {
                        C_NomPer});
            return ((directivo[])(results[0]));
        }
        
        /// <remarks/>
        public void listarDirectivosAsync(string C_NomPer) {
            this.listarDirectivosAsync(C_NomPer, null);
        }
        
        /// <remarks/>
        public void listarDirectivosAsync(string C_NomPer, object userState) {
            if ((this.listarDirectivosOperationCompleted == null)) {
                this.listarDirectivosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarDirectivosOperationCompleted);
            }
            this.InvokeAsync("listarDirectivos", new object[] {
                        C_NomPer}, this.listarDirectivosOperationCompleted, userState);
        }
        
        private void OnlistarDirectivosOperationCompleted(object arg) {
            if ((this.listarDirectivosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarDirectivosCompleted(this, new listarDirectivosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IJuntaService/CreaJunta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreaJunta(System.DateTime D_Fecha, [System.Xml.Serialization.XmlIgnoreAttribute()] bool D_FechaSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string C_Hora, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string C_Tema, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string C_Acuerdo, out int CreaJuntaResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool CreaJuntaResultSpecified) {
            object[] results = this.Invoke("CreaJunta", new object[] {
                        D_Fecha,
                        D_FechaSpecified,
                        C_Hora,
                        C_Tema,
                        C_Acuerdo});
            CreaJuntaResult = ((int)(results[0]));
            CreaJuntaResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void CreaJuntaAsync(System.DateTime D_Fecha, bool D_FechaSpecified, string C_Hora, string C_Tema, string C_Acuerdo) {
            this.CreaJuntaAsync(D_Fecha, D_FechaSpecified, C_Hora, C_Tema, C_Acuerdo, null);
        }
        
        /// <remarks/>
        public void CreaJuntaAsync(System.DateTime D_Fecha, bool D_FechaSpecified, string C_Hora, string C_Tema, string C_Acuerdo, object userState) {
            if ((this.CreaJuntaOperationCompleted == null)) {
                this.CreaJuntaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreaJuntaOperationCompleted);
            }
            this.InvokeAsync("CreaJunta", new object[] {
                        D_Fecha,
                        D_FechaSpecified,
                        C_Hora,
                        C_Tema,
                        C_Acuerdo}, this.CreaJuntaOperationCompleted, userState);
        }
        
        private void OnCreaJuntaOperationCompleted(object arg) {
            if ((this.CreaJuntaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreaJuntaCompleted(this, new CreaJuntaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IJuntaService/CreaJuntaDirectivos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreaJuntaDirectivos(int N_IdJunta, [System.Xml.Serialization.XmlIgnoreAttribute()] bool N_IdJuntaSpecified, int N_IdDirectivo, [System.Xml.Serialization.XmlIgnoreAttribute()] bool N_IdDirectivoSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string C_PreJun, bool B_Estado, [System.Xml.Serialization.XmlIgnoreAttribute()] bool B_EstadoSpecified, out int CreaJuntaDirectivosResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool CreaJuntaDirectivosResultSpecified) {
            object[] results = this.Invoke("CreaJuntaDirectivos", new object[] {
                        N_IdJunta,
                        N_IdJuntaSpecified,
                        N_IdDirectivo,
                        N_IdDirectivoSpecified,
                        C_PreJun,
                        B_Estado,
                        B_EstadoSpecified});
            CreaJuntaDirectivosResult = ((int)(results[0]));
            CreaJuntaDirectivosResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void CreaJuntaDirectivosAsync(int N_IdJunta, bool N_IdJuntaSpecified, int N_IdDirectivo, bool N_IdDirectivoSpecified, string C_PreJun, bool B_Estado, bool B_EstadoSpecified) {
            this.CreaJuntaDirectivosAsync(N_IdJunta, N_IdJuntaSpecified, N_IdDirectivo, N_IdDirectivoSpecified, C_PreJun, B_Estado, B_EstadoSpecified, null);
        }
        
        /// <remarks/>
        public void CreaJuntaDirectivosAsync(int N_IdJunta, bool N_IdJuntaSpecified, int N_IdDirectivo, bool N_IdDirectivoSpecified, string C_PreJun, bool B_Estado, bool B_EstadoSpecified, object userState) {
            if ((this.CreaJuntaDirectivosOperationCompleted == null)) {
                this.CreaJuntaDirectivosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreaJuntaDirectivosOperationCompleted);
            }
            this.InvokeAsync("CreaJuntaDirectivos", new object[] {
                        N_IdJunta,
                        N_IdJuntaSpecified,
                        N_IdDirectivo,
                        N_IdDirectivoSpecified,
                        C_PreJun,
                        B_Estado,
                        B_EstadoSpecified}, this.CreaJuntaDirectivosOperationCompleted, userState);
        }
        
        private void OnCreaJuntaDirectivosOperationCompleted(object arg) {
            if ((this.CreaJuntaDirectivosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreaJuntaDirectivosCompleted(this, new CreaJuntaDirectivosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Architecs.ReunionesService.Dominio")]
    public partial class directivo {
        
        private bool b_EstadoField;
        
        private bool b_EstadoFieldSpecified;
        
        private string c_CargoField;
        
        private string c_NomPerField;
        
        private int n_IdDirectivoField;
        
        private bool n_IdDirectivoFieldSpecified;
        
        private int n_IdResidenteField;
        
        private bool n_IdResidenteFieldSpecified;
        
        /// <comentarios/>
        public bool B_Estado {
            get {
                return this.b_EstadoField;
            }
            set {
                this.b_EstadoField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool B_EstadoSpecified {
            get {
                return this.b_EstadoFieldSpecified;
            }
            set {
                this.b_EstadoFieldSpecified = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string C_Cargo {
            get {
                return this.c_CargoField;
            }
            set {
                this.c_CargoField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string C_NomPer {
            get {
                return this.c_NomPerField;
            }
            set {
                this.c_NomPerField = value;
            }
        }
        
        /// <comentarios/>
        public int N_IdDirectivo {
            get {
                return this.n_IdDirectivoField;
            }
            set {
                this.n_IdDirectivoField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool N_IdDirectivoSpecified {
            get {
                return this.n_IdDirectivoFieldSpecified;
            }
            set {
                this.n_IdDirectivoFieldSpecified = value;
            }
        }
        
        /// <comentarios/>
        public int N_IdResidente {
            get {
                return this.n_IdResidenteField;
            }
            set {
                this.n_IdResidenteField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool N_IdResidenteSpecified {
            get {
                return this.n_IdResidenteFieldSpecified;
            }
            set {
                this.n_IdResidenteFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void listarDirectivosCompletedEventHandler(object sender, listarDirectivosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarDirectivosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarDirectivosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public directivo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((directivo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void CreaJuntaCompletedEventHandler(object sender, CreaJuntaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreaJuntaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreaJuntaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int CreaJuntaResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool CreaJuntaResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void CreaJuntaDirectivosCompletedEventHandler(object sender, CreaJuntaDirectivosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreaJuntaDirectivosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreaJuntaDirectivosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int CreaJuntaDirectivosResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool CreaJuntaDirectivosResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591