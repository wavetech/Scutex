﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaveTech.Scutex.Providers.WebServicesProvider.WcfServices.ActivationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServices.ActivationService.IActivationService")]
    public interface IActivationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActivationService/ActivateLicense", ReplyAction="http://tempuri.org/IActivationService/ActivateLicenseResponse")]
        string ActivateLicense(string token, string payload);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActivationService/BasicServiceTest", ReplyAction="http://tempuri.org/IActivationService/BasicServiceTestResponse")]
        string BasicServiceTest();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActivationService/FileSystemServiceTest", ReplyAction="http://tempuri.org/IActivationService/FileSystemServiceTestResponse")]
        bool FileSystemServiceTest();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IActivationService/DatabaseServiceTest", ReplyAction="http://tempuri.org/IActivationService/DatabaseServiceTestResponse")]
        bool DatabaseServiceTest();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IActivationServiceChannel : WaveTech.Scutex.Providers.WebServicesProvider.WcfServices.ActivationService.IActivationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ActivationServiceClient : System.ServiceModel.ClientBase<WaveTech.Scutex.Providers.WebServicesProvider.WcfServices.ActivationService.IActivationService>, WaveTech.Scutex.Providers.WebServicesProvider.WcfServices.ActivationService.IActivationService {
        
        public ActivationServiceClient() {
        }
        
        public ActivationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ActivationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActivationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ActivationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ActivateLicense(string token, string payload) {
            return base.Channel.ActivateLicense(token, payload);
        }
        
        public string BasicServiceTest() {
            return base.Channel.BasicServiceTest();
        }
        
        public bool FileSystemServiceTest() {
            return base.Channel.FileSystemServiceTest();
        }
        
        public bool DatabaseServiceTest() {
            return base.Channel.DatabaseServiceTest();
        }
    }
}
