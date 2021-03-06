//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod bir araç tarafından oluşturuldu.
//
//     Bu dosyada yapılacak değişiklikler hatalı davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceQoniac
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceQoniac.IServiceQoniac")]
    public interface IServiceQoniac
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQoniac/GetCurrencyToWords", ReplyAction="http://tempuri.org/IServiceQoniac/GetCurrencyToWordsResponse")]
        System.Threading.Tasks.Task<string> GetCurrencyToWordsAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IServiceQoniacChannel : ServiceReferenceQoniac.IServiceQoniac, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ServiceQoniacClient : System.ServiceModel.ClientBase<ServiceReferenceQoniac.IServiceQoniac>, ServiceReferenceQoniac.IServiceQoniac
    {
        
        /// <summary>
        /// Hizmet uç noktasını yapılandırmak için bu kısmi metodu uygulayın.
        /// </summary>
        /// <param name="serviceEndpoint">Yapılandırılacak uç nokta</param>
        /// <param name="clientCredentials">İstemci kimlik bilgileri</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceQoniacClient() : 
                base(ServiceQoniacClient.GetDefaultBinding(), ServiceQoniacClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServiceQoniac.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceQoniacClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceQoniacClient.GetBindingForEndpoint(endpointConfiguration), ServiceQoniacClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceQoniacClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceQoniacClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceQoniacClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceQoniacClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceQoniacClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> GetCurrencyToWordsAsync(string value)
        {
            return base.Channel.GetCurrencyToWordsAsync(value);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceQoniac))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("\'{0}\' adlı uç nokta bulunamadı.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceQoniac))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:49459/ServiceQoniac.svc");
            }
            throw new System.InvalidOperationException(string.Format("\'{0}\' adlı uç nokta bulunamadı.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceQoniacClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServiceQoniac);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceQoniacClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServiceQoniac);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServiceQoniac,
        }
    }
}
