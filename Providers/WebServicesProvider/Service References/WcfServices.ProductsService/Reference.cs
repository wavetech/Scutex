﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaveTech.Scutex.Providers.WebServicesProvider.WcfServices.ProductsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServices.ProductsService.IProductsService")]
    public interface IProductsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/AddProduct", ReplyAction="http://tempuri.org/IProductsService/AddProductResponse")]
        string AddProduct(string token, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/GetLicenseKeysForProduct", ReplyAction="http://tempuri.org/IProductsService/GetLicenseKeysForProductResponse")]
        string GetLicenseKeysForProduct(string token, string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductsService/AddLicenseKeysForProduct", ReplyAction="http://tempuri.org/IProductsService/AddLicenseKeysForProductResponse")]
        string AddLicenseKeysForProduct(string token, string data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductsServiceChannel : WaveTech.Scutex.Providers.WebServicesProvider.WcfServices.ProductsService.IProductsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductsServiceClient : System.ServiceModel.ClientBase<WaveTech.Scutex.Providers.WebServicesProvider.WcfServices.ProductsService.IProductsService>, WaveTech.Scutex.Providers.WebServicesProvider.WcfServices.ProductsService.IProductsService {
        
        public ProductsServiceClient() {
        }
        
        public ProductsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddProduct(string token, string data) {
            return base.Channel.AddProduct(token, data);
        }
        
        public string GetLicenseKeysForProduct(string token, string data) {
            return base.Channel.GetLicenseKeysForProduct(token, data);
        }
        
        public string AddLicenseKeysForProduct(string token, string data) {
            return base.Channel.AddLicenseKeysForProduct(token, data);
        }
    }
}
