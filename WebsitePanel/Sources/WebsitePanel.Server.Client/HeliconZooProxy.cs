//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5456
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace WebsitePanel.Providers.HeliconZoo {
    using System.Xml.Serialization;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Diagnostics;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="HeliconZooSoap", Namespace="http://smbsaas/websitepanel/server/")]
    public partial class HeliconZoo : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        public ServiceProviderSettingsSoapHeader ServiceProviderSettingsSoapHeaderValue;
        
        private System.Threading.SendOrPostCallback GetEnginesOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetEnginesOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsEnginesEnabledOperationCompleted;
        
        private System.Threading.SendOrPostCallback SwithEnginesEnabledOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEnabledEnginesForSiteOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetEnabledEnginesForSiteOperationCompleted;
        
        /// <remarks/>
        public HeliconZoo() {
            this.Url = "http://localhost:9003/HeliconZoo.asmx";
        }
        
        /// <remarks/>
        public event GetEnginesCompletedEventHandler GetEnginesCompleted;
        
        /// <remarks/>
        public event SetEnginesCompletedEventHandler SetEnginesCompleted;
        
        /// <remarks/>
        public event IsEnginesEnabledCompletedEventHandler IsEnginesEnabledCompleted;
        
        /// <remarks/>
        public event SwithEnginesEnabledCompletedEventHandler SwithEnginesEnabledCompleted;
        
        /// <remarks/>
        public event GetEnabledEnginesForSiteCompletedEventHandler GetEnabledEnginesForSiteCompleted;
        
        /// <remarks/>
        public event SetEnabledEnginesForSiteCompletedEventHandler SetEnabledEnginesForSiteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetEngines", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public HeliconZooEngine[] GetEngines() {
            object[] results = this.Invoke("GetEngines", new object[0]);
            return ((HeliconZooEngine[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetEngines(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetEngines", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public HeliconZooEngine[] EndGetEngines(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((HeliconZooEngine[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEnginesAsync() {
            this.GetEnginesAsync(null);
        }
        
        /// <remarks/>
        public void GetEnginesAsync(object userState) {
            if ((this.GetEnginesOperationCompleted == null)) {
                this.GetEnginesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEnginesOperationCompleted);
            }
            this.InvokeAsync("GetEngines", new object[0], this.GetEnginesOperationCompleted, userState);
        }
        
        private void OnGetEnginesOperationCompleted(object arg) {
            if ((this.GetEnginesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEnginesCompleted(this, new GetEnginesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/SetEngines", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetEngines(HeliconZooEngine[] userEngines) {
            this.Invoke("SetEngines", new object[] {
                        userEngines});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSetEngines(HeliconZooEngine[] userEngines, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SetEngines", new object[] {
                        userEngines}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndSetEngines(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void SetEnginesAsync(HeliconZooEngine[] userEngines) {
            this.SetEnginesAsync(userEngines, null);
        }
        
        /// <remarks/>
        public void SetEnginesAsync(HeliconZooEngine[] userEngines, object userState) {
            if ((this.SetEnginesOperationCompleted == null)) {
                this.SetEnginesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetEnginesOperationCompleted);
            }
            this.InvokeAsync("SetEngines", new object[] {
                        userEngines}, this.SetEnginesOperationCompleted, userState);
        }
        
        private void OnSetEnginesOperationCompleted(object arg) {
            if ((this.SetEnginesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetEnginesCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/IsEnginesEnabled", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IsEnginesEnabled() {
            object[] results = this.Invoke("IsEnginesEnabled", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIsEnginesEnabled(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("IsEnginesEnabled", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndIsEnginesEnabled(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void IsEnginesEnabledAsync() {
            this.IsEnginesEnabledAsync(null);
        }
        
        /// <remarks/>
        public void IsEnginesEnabledAsync(object userState) {
            if ((this.IsEnginesEnabledOperationCompleted == null)) {
                this.IsEnginesEnabledOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsEnginesEnabledOperationCompleted);
            }
            this.InvokeAsync("IsEnginesEnabled", new object[0], this.IsEnginesEnabledOperationCompleted, userState);
        }
        
        private void OnIsEnginesEnabledOperationCompleted(object arg) {
            if ((this.IsEnginesEnabledCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsEnginesEnabledCompleted(this, new IsEnginesEnabledCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/SwithEnginesEnabled", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SwithEnginesEnabled(bool enabled) {
            this.Invoke("SwithEnginesEnabled", new object[] {
                        enabled});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSwithEnginesEnabled(bool enabled, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SwithEnginesEnabled", new object[] {
                        enabled}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndSwithEnginesEnabled(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void SwithEnginesEnabledAsync(bool enabled) {
            this.SwithEnginesEnabledAsync(enabled, null);
        }
        
        /// <remarks/>
        public void SwithEnginesEnabledAsync(bool enabled, object userState) {
            if ((this.SwithEnginesEnabledOperationCompleted == null)) {
                this.SwithEnginesEnabledOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSwithEnginesEnabledOperationCompleted);
            }
            this.InvokeAsync("SwithEnginesEnabled", new object[] {
                        enabled}, this.SwithEnginesEnabledOperationCompleted, userState);
        }
        
        private void OnSwithEnginesEnabledOperationCompleted(object arg) {
            if ((this.SwithEnginesEnabledCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SwithEnginesEnabledCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetEnabledEnginesForSite", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetEnabledEnginesForSite(string siteId) {
            object[] results = this.Invoke("GetEnabledEnginesForSite", new object[] {
                        siteId});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetEnabledEnginesForSite(string siteId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetEnabledEnginesForSite", new object[] {
                        siteId}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndGetEnabledEnginesForSite(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEnabledEnginesForSiteAsync(string siteId) {
            this.GetEnabledEnginesForSiteAsync(siteId, null);
        }
        
        /// <remarks/>
        public void GetEnabledEnginesForSiteAsync(string siteId, object userState) {
            if ((this.GetEnabledEnginesForSiteOperationCompleted == null)) {
                this.GetEnabledEnginesForSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEnabledEnginesForSiteOperationCompleted);
            }
            this.InvokeAsync("GetEnabledEnginesForSite", new object[] {
                        siteId}, this.GetEnabledEnginesForSiteOperationCompleted, userState);
        }
        
        private void OnGetEnabledEnginesForSiteOperationCompleted(object arg) {
            if ((this.GetEnabledEnginesForSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEnabledEnginesForSiteCompleted(this, new GetEnabledEnginesForSiteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/SetEnabledEnginesForSite", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetEnabledEnginesForSite(string siteId, string[] engineNames) {
            this.Invoke("SetEnabledEnginesForSite", new object[] {
                        siteId,
                        engineNames});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSetEnabledEnginesForSite(string siteId, string[] engineNames, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SetEnabledEnginesForSite", new object[] {
                        siteId,
                        engineNames}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndSetEnabledEnginesForSite(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void SetEnabledEnginesForSiteAsync(string siteId, string[] engineNames) {
            this.SetEnabledEnginesForSiteAsync(siteId, engineNames, null);
        }
        
        /// <remarks/>
        public void SetEnabledEnginesForSiteAsync(string siteId, string[] engineNames, object userState) {
            if ((this.SetEnabledEnginesForSiteOperationCompleted == null)) {
                this.SetEnabledEnginesForSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetEnabledEnginesForSiteOperationCompleted);
            }
            this.InvokeAsync("SetEnabledEnginesForSite", new object[] {
                        siteId,
                        engineNames}, this.SetEnabledEnginesForSiteOperationCompleted, userState);
        }
        
        private void OnSetEnabledEnginesForSiteOperationCompleted(object arg) {
            if ((this.SetEnabledEnginesForSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetEnabledEnginesForSiteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetEnginesCompletedEventHandler(object sender, GetEnginesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEnginesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEnginesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public HeliconZooEngine[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((HeliconZooEngine[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void SetEnginesCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void IsEnginesEnabledCompletedEventHandler(object sender, IsEnginesEnabledCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsEnginesEnabledCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsEnginesEnabledCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void SwithEnginesEnabledCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetEnabledEnginesForSiteCompletedEventHandler(object sender, GetEnabledEnginesForSiteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEnabledEnginesForSiteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEnabledEnginesForSiteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void SetEnabledEnginesForSiteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}
