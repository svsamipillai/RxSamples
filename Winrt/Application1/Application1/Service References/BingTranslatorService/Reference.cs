﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 11.0.50214.1
// 
namespace Application1.BingTranslatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", ConfigurationName="BingTranslatorService.LanguageService")]
    public interface LanguageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguages", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguagesRespon" +
            "se")]
        System.Threading.Tasks.Task<Application1.BingTranslatorService.GetLanguagesResponse> GetLanguagesAsync(Application1.BingTranslatorService.GetLanguagesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNames", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/GetLanguageNamesRe" +
            "sponse")]
        System.Threading.Tasks.Task<Application1.BingTranslatorService.GetLanguageNamesResponse> GetLanguageNamesAsync(Application1.BingTranslatorService.GetLanguageNamesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Detect", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/DetectResponse")]
        System.Threading.Tasks.Task<Application1.BingTranslatorService.DetectResponse> DetectAsync(Application1.BingTranslatorService.DetectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/Translate", ReplyAction="http://api.microsofttranslator.com/v1/soap.svc/LanguageService/TranslateResponse")]
        System.Threading.Tasks.Task<Application1.BingTranslatorService.TranslateResponse> TranslateAsync(Application1.BingTranslatorService.TranslateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLanguages", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class GetLanguagesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string appId;
        
        public GetLanguagesRequest() {
        }
        
        public GetLanguagesRequest(string appId) {
            this.appId = appId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLanguagesResponse", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class GetLanguagesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<string> GetLanguagesResult;
        
        public GetLanguagesResponse() {
        }
        
        public GetLanguagesResponse(System.Collections.ObjectModel.ObservableCollection<string> GetLanguagesResult) {
            this.GetLanguagesResult = GetLanguagesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLanguageNames", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class GetLanguageNamesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string appId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=1)]
        public string locale;
        
        public GetLanguageNamesRequest() {
        }
        
        public GetLanguageNamesRequest(string appId, string locale) {
            this.appId = appId;
            this.locale = locale;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetLanguageNamesResponse", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class GetLanguageNamesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<string> GetLanguageNamesResult;
        
        public GetLanguageNamesResponse() {
        }
        
        public GetLanguageNamesResponse(System.Collections.ObjectModel.ObservableCollection<string> GetLanguageNamesResult) {
            this.GetLanguageNamesResult = GetLanguageNamesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Detect", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class DetectRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string appId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=1)]
        public string text;
        
        public DetectRequest() {
        }
        
        public DetectRequest(string appId, string text) {
            this.appId = appId;
            this.text = text;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DetectResponse", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class DetectResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string DetectResult;
        
        public DetectResponse() {
        }
        
        public DetectResponse(string DetectResult) {
            this.DetectResult = DetectResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Translate", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class TranslateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string appId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=1)]
        public string text;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=2)]
        public string from;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=3)]
        public string to;
        
        public TranslateRequest() {
        }
        
        public TranslateRequest(string appId, string text, string from, string to) {
            this.appId = appId;
            this.text = text;
            this.from = from;
            this.to = to;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TranslateResponse", WrapperNamespace="http://api.microsofttranslator.com/v1/soap.svc", IsWrapped=true)]
    public partial class TranslateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://api.microsofttranslator.com/v1/soap.svc", Order=0)]
        public string TranslateResult;
        
        public TranslateResponse() {
        }
        
        public TranslateResponse(string TranslateResult) {
            this.TranslateResult = TranslateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LanguageServiceChannel : Application1.BingTranslatorService.LanguageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LanguageServiceClient : System.ServiceModel.ClientBase<Application1.BingTranslatorService.LanguageService>, Application1.BingTranslatorService.LanguageService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public LanguageServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(LanguageServiceClient.GetBindingForEndpoint(endpointConfiguration), LanguageServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LanguageServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(LanguageServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LanguageServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(LanguageServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LanguageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<Application1.BingTranslatorService.GetLanguagesResponse> GetLanguagesAsync(Application1.BingTranslatorService.GetLanguagesRequest request) {
            return base.Channel.GetLanguagesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Application1.BingTranslatorService.GetLanguageNamesResponse> GetLanguageNamesAsync(Application1.BingTranslatorService.GetLanguageNamesRequest request) {
            return base.Channel.GetLanguageNamesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Application1.BingTranslatorService.DetectResponse> DetectAsync(Application1.BingTranslatorService.DetectRequest request) {
            return base.Channel.DetectAsync(request);
        }
        
        public System.Threading.Tasks.Task<Application1.BingTranslatorService.TranslateResponse> TranslateAsync(Application1.BingTranslatorService.TranslateRequest request) {
            return base.Channel.TranslateAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_LanguageService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_LanguageService1)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_LanguageService)) {
                return new System.ServiceModel.EndpointAddress("http://api.microsofttranslator.com/V1/soap.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_LanguageService1)) {
                return new System.ServiceModel.EndpointAddress("http://api.microsofttranslator.com/V1/soap.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_LanguageService,
            
            BasicHttpBinding_LanguageService1,
        }
    }
}
