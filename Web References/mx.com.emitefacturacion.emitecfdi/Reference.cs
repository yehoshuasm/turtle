﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5483
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.5483.
// 
namespace turtle.mx.com.emitefacturacion.emitecfdi {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CFDIEmiteBinding", Namespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
    public partial class CFDIEmite : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public CFDIEmite() {
            this.Url = "http://emitecfdi.emitefacturacion.com.mx/ws.php";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarCFDI", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public Respuesta generarCFDI(string comprobante, string usuario, string password) {
            object[] results = this.Invoke("generarCFDI", new object[] {
                        comprobante,
                        usuario,
                        password});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarCFDI(string comprobante, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarCFDI", new object[] {
                        comprobante,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public Respuesta EndgenerarCFDI(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarCFDIPDF", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public RespuestaCFDIPDF generarCFDIPDF(string comprobante, string usuario, string password) {
            object[] results = this.Invoke("generarCFDIPDF", new object[] {
                        comprobante,
                        usuario,
                        password});
            return ((RespuestaCFDIPDF)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarCFDIPDF(string comprobante, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarCFDIPDF", new object[] {
                        comprobante,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaCFDIPDF EndgenerarCFDIPDF(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaCFDIPDF)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarCFDIVolvo", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public RespuestaVolvo generarCFDIVolvo(string comprobante, string usuario, string password) {
            object[] results = this.Invoke("generarCFDIVolvo", new object[] {
                        comprobante,
                        usuario,
                        password});
            return ((RespuestaVolvo)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarCFDIVolvo(string comprobante, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarCFDIVolvo", new object[] {
                        comprobante,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaVolvo EndgenerarCFDIVolvo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaVolvo)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarCFDIRoble", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public RespuestaRoble generarCFDIRoble(string comprobante, string usuario, string password) {
            object[] results = this.Invoke("generarCFDIRoble", new object[] {
                        comprobante,
                        usuario,
                        password});
            return ((RespuestaRoble)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarCFDIRoble(string comprobante, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarCFDIRoble", new object[] {
                        comprobante,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaRoble EndgenerarCFDIRoble(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaRoble)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarCFDICT", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public RespuestaCFDIPDF generarCFDICT(string comprobante, string usuario, string password, string transaccion) {
            object[] results = this.Invoke("generarCFDICT", new object[] {
                        comprobante,
                        usuario,
                        password,
                        transaccion});
            return ((RespuestaCFDIPDF)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarCFDICT(string comprobante, string usuario, string password, string transaccion, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarCFDICT", new object[] {
                        comprobante,
                        usuario,
                        password,
                        transaccion}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaCFDIPDF EndgenerarCFDICT(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaCFDIPDF)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarUTF8", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public Respuesta generarUTF8(string comprobante) {
            object[] results = this.Invoke("generarUTF8", new object[] {
                        comprobante});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarUTF8(string comprobante, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarUTF8", new object[] {
                        comprobante}, callback, asyncState);
        }
        
        /// <remarks/>
        public Respuesta EndgenerarUTF8(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/consultaSaldo", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuestaSaldo")]
        public string consultaSaldo(string usuario, string password) {
            object[] results = this.Invoke("consultaSaldo", new object[] {
                        usuario,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginconsultaSaldo(string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("consultaSaldo", new object[] {
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndconsultaSaldo(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/cancelarComprobantes", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public string cancelarComprobantes(string uuid, string usuario, string password) {
            object[] results = this.Invoke("cancelarComprobantes", new object[] {
                        uuid,
                        usuario,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegincancelarComprobantes(string uuid, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("cancelarComprobantes", new object[] {
                        uuid,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndcancelarComprobantes(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarAddenda", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public RespuestaVolvo generarAddenda(string comprobante, string addenda, string usuario, string password) {
            object[] results = this.Invoke("generarAddenda", new object[] {
                        comprobante,
                        addenda,
                        usuario,
                        password});
            return ((RespuestaVolvo)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarAddenda(string comprobante, string addenda, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarAddenda", new object[] {
                        comprobante,
                        addenda,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaVolvo EndgenerarAddenda(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaVolvo)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarPDF", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public RespuestaPDF generarPDF(string comprobante, string usuario, string password) {
            object[] results = this.Invoke("generarPDF", new object[] {
                        comprobante,
                        usuario,
                        password});
            return ((RespuestaPDF)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarPDF(string comprobante, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarPDF", new object[] {
                        comprobante,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaPDF EndgenerarPDF(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaPDF)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarDeTXTaCFDI", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public RespuestaCFDIPDF generarDeTXTaCFDI(string comprobante, string usuario, string password) {
            object[] results = this.Invoke("generarDeTXTaCFDI", new object[] {
                        comprobante,
                        usuario,
                        password});
            return ((RespuestaCFDIPDF)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarDeTXTaCFDI(string comprobante, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarDeTXTaCFDI", new object[] {
                        comprobante,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaCFDIPDF EndgenerarDeTXTaCFDI(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaCFDIPDF)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://emitecfdi.emitefacturacion.com.mx/ws.php/generarCFDaCFDIPDF", RequestNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php", ResponseNamespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
        [return: System.Xml.Serialization.SoapElementAttribute("respuesta")]
        public RespuestaCFDIPDF generarCFDaCFDIPDF(string comprobante, string usuario, string password) {
            object[] results = this.Invoke("generarCFDaCFDIPDF", new object[] {
                        comprobante,
                        usuario,
                        password});
            return ((RespuestaCFDIPDF)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingenerarCFDaCFDIPDF(string comprobante, string usuario, string password, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("generarCFDaCFDIPDF", new object[] {
                        comprobante,
                        usuario,
                        password}, callback, asyncState);
        }
        
        /// <remarks/>
        public RespuestaCFDIPDF EndgenerarCFDaCFDIPDF(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((RespuestaCFDIPDF)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
    public partial class Respuesta {
        
        private string mensajeField;
        
        private string comprobanteField;
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        public string comprobante {
            get {
                return this.comprobanteField;
            }
            set {
                this.comprobanteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
    public partial class RespuestaPDF {
        
        private string mensajeField;
        
        private string pdfField;
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        public string pdf {
            get {
                return this.pdfField;
            }
            set {
                this.pdfField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
    public partial class RespuestaRoble {
        
        private string mensajeField;
        
        private string qrField;
        
        private string pdfField;
        
        private string comprobanteField;
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        public string qr {
            get {
                return this.qrField;
            }
            set {
                this.qrField = value;
            }
        }
        
        /// <remarks/>
        public string pdf {
            get {
                return this.pdfField;
            }
            set {
                this.pdfField = value;
            }
        }
        
        /// <remarks/>
        public string comprobante {
            get {
                return this.comprobanteField;
            }
            set {
                this.comprobanteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
    public partial class RespuestaVolvo {
        
        private string mensajeField;
        
        private string uuidField;
        
        private string folioField;
        
        private string dominioField;
        
        private string ordenVentaField;
        
        private string fechaEmisionField;
        
        private string fechaField;
        
        private string horaField;
        
        private string pdfField;
        
        private string comprobanteField;
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        public string uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
            }
        }
        
        /// <remarks/>
        public string folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
            }
        }
        
        /// <remarks/>
        public string dominio {
            get {
                return this.dominioField;
            }
            set {
                this.dominioField = value;
            }
        }
        
        /// <remarks/>
        public string ordenVenta {
            get {
                return this.ordenVentaField;
            }
            set {
                this.ordenVentaField = value;
            }
        }
        
        /// <remarks/>
        public string fechaEmision {
            get {
                return this.fechaEmisionField;
            }
            set {
                this.fechaEmisionField = value;
            }
        }
        
        /// <remarks/>
        public string fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }
        
        /// <remarks/>
        public string hora {
            get {
                return this.horaField;
            }
            set {
                this.horaField = value;
            }
        }
        
        /// <remarks/>
        public string pdf {
            get {
                return this.pdfField;
            }
            set {
                this.pdfField = value;
            }
        }
        
        /// <remarks/>
        public string comprobante {
            get {
                return this.comprobanteField;
            }
            set {
                this.comprobanteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://emitecfdi.emitefacturacion.com.mx/ws.php")]
    public partial class RespuestaCFDIPDF {
        
        private string mensajeField;
        
        private string pdfField;
        
        private string comprobanteField;
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        public string pdf {
            get {
                return this.pdfField;
            }
            set {
                this.pdfField = value;
            }
        }
        
        /// <remarks/>
        public string comprobante {
            get {
                return this.comprobanteField;
            }
            set {
                this.comprobanteField = value;
            }
        }
    }
}