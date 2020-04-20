﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceRef
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MySoapService")]
    public partial class CompositeType : object
    {
        
        private bool BoolValueField;
        
        private string StringValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue
        {
            get
            {
                return this.StringValueField;
            }
            set
            {
                this.StringValueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRef.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ServiceRef.CompositeType GetDataUsingDataContract(ServiceRef.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServiceRef.CompositeType> GetDataUsingDataContractAsync(ServiceRef.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCity", ReplyAction="http://tempuri.org/IService1/GetCityResponse")]
        string GetCity(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCity", ReplyAction="http://tempuri.org/IService1/GetCityResponse")]
        System.Threading.Tasks.Task<string> GetCityAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCountry", ReplyAction="http://tempuri.org/IService1/GetCountryResponse")]
        string GetCountry(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCountry", ReplyAction="http://tempuri.org/IService1/GetCountryResponse")]
        System.Threading.Tasks.Task<string> GetCountryAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFarenheit", ReplyAction="http://tempuri.org/IService1/GetFarenheitResponse")]
        double GetFarenheit(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFarenheit", ReplyAction="http://tempuri.org/IService1/GetFarenheitResponse")]
        System.Threading.Tasks.Task<double> GetFarenheitAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetName", ReplyAction="http://tempuri.org/IService1/GetNameResponse")]
        string GetName(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetName", ReplyAction="http://tempuri.org/IService1/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDescription", ReplyAction="http://tempuri.org/IService1/GetDescriptionResponse")]
        string GetDescription(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDescription", ReplyAction="http://tempuri.org/IService1/GetDescriptionResponse")]
        System.Threading.Tasks.Task<string> GetDescriptionAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTemperature", ReplyAction="http://tempuri.org/IService1/GetTemperatureResponse")]
        double GetTemperature(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetTemperature", ReplyAction="http://tempuri.org/IService1/GetTemperatureResponse")]
        System.Threading.Tasks.Task<double> GetTemperatureAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWind", ReplyAction="http://tempuri.org/IService1/GetWindResponse")]
        double GetWind(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetWind", ReplyAction="http://tempuri.org/IService1/GetWindResponse")]
        System.Threading.Tasks.Task<double> GetWindAsync(double value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IService1Channel : ServiceRef.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceRef.IService1>, ServiceRef.IService1
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string GetData(int value)
        {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value)
        {
            return base.Channel.GetDataAsync(value);
        }
        
        public ServiceRef.CompositeType GetDataUsingDataContract(ServiceRef.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ServiceRef.CompositeType> GetDataUsingDataContractAsync(ServiceRef.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string GetCity(string value)
        {
            return base.Channel.GetCity(value);
        }
        
        public System.Threading.Tasks.Task<string> GetCityAsync(string value)
        {
            return base.Channel.GetCityAsync(value);
        }
        
        public string GetCountry(string value)
        {
            return base.Channel.GetCountry(value);
        }
        
        public System.Threading.Tasks.Task<string> GetCountryAsync(string value)
        {
            return base.Channel.GetCountryAsync(value);
        }
        
        public double GetFarenheit(double value)
        {
            return base.Channel.GetFarenheit(value);
        }
        
        public System.Threading.Tasks.Task<double> GetFarenheitAsync(double value)
        {
            return base.Channel.GetFarenheitAsync(value);
        }
        
        public string GetName(string value)
        {
            return base.Channel.GetName(value);
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync(string value)
        {
            return base.Channel.GetNameAsync(value);
        }
        
        public string GetDescription(string value)
        {
            return base.Channel.GetDescription(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDescriptionAsync(string value)
        {
            return base.Channel.GetDescriptionAsync(value);
        }
        
        public double GetTemperature(double value)
        {
            return base.Channel.GetTemperature(value);
        }
        
        public System.Threading.Tasks.Task<double> GetTemperatureAsync(double value)
        {
            return base.Channel.GetTemperatureAsync(value);
        }
        
        public double GetWind(double value)
        {
            return base.Channel.GetWind(value);
        }
        
        public System.Threading.Tasks.Task<double> GetWindAsync(double value)
        {
            return base.Channel.GetWindAsync(value);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:64066/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
