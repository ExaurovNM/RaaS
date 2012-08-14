using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.Text;
using RadiantRFID.RaaS.DomainModel.DeviceRepositoryService;
using RadiantRFID.RaaS.DomainModel.DeviceStatusRepositoryService;
using RadiantRFID.RaaS.DomainModel.TagReadHistoryRepositoryService;

namespace RadiantRFID.RaaS.DomainModel.Services
{
    public static class ServiceClientFactory
    {
        public static DeviceRepositoryClient GetDeviceRepository(string userName, string password)
        {
            //var serviceConfiguration = configurationSyncProvider.GetServiceConfiguration();
            //var binding = GetDefaultBinding();
            //var endpointAddress = GetEndpointAddress(serviceConfiguration.Uri, DeviceRepositoryServiceUrl);
            //var client = new DeviceRepositoryClient(binding, endpointAddress);

            var client = new DeviceRepositoryClient();

            SetCredentials(client, userName, password);

            return client;
        }

        public static DeviceStatusRepositoryClient GetDeviceStatusRepository(string userName, string password)
        {
            var client = new DeviceStatusRepositoryClient();

            SetCredentials(client, userName, password);

            return client;
        }

        public static TagReadHistoryRepositoryClient GetTagReadHistoryRepository(string userName, string password)
        {
            var client = new TagReadHistoryRepositoryClient();

            SetCredentials(client, userName, password);

            return client;
        }


        //private static Binding GetDefaultBinding()
        //{
        //    const int MaxReceivedMessageSize = 10 * 1024 * 1024;

        //    var binding = new BasicHttpBinding
        //                      {
        //                          MaxBufferSize = MaxReceivedMessageSize,
        //                          MaxBufferPoolSize = MaxReceivedMessageSize*2,
        //                          MaxReceivedMessageSize = MaxReceivedMessageSize
        //                      };

        //    var security = binding.Security;
        //    security.Mode = BasicHttpSecurityMode.TransportWithMessageCredential;

        //    var transportSecurity = security.Transport;
        //    transportSecurity.ClientCredentialType = HttpClientCredentialType.None;
        //    transportSecurity.ProxyCredentialType = HttpProxyCredentialType.None;
        //    transportSecurity.Realm = string.Empty;

        //    var messageSecurity = security.Message;
        //    messageSecurity.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
        //    messageSecurity.AlgorithmSuite = SecurityAlgorithmSuite.Default;

        //    return binding;
        //}

        //private static EndpointAddress GetEndpointAddress(string baserUri, string serviceUri)
        //{
        //    var uri = string.Format(CultureInfo.InvariantCulture, "{0}{1}", baserUri, serviceUri);
        //    return new EndpointAddress(uri);
        //}

        //private static TClientBase GetClient<TChannel, TClientBase>(Binding binding, EndpointAddress endpointAddress)
        //    where TChannel : class
        //    where TClientBase : ClientBase<TChannel>
        //{
        //    var clientType = typeof(TClientBase);
        //    var constructor = clientType.GetConstructor(new[] { typeof(Binding), typeof(EndpointAddress) });
        //    if (constructor == null)
        //        throw new InvalidOperationException(
        //            string.Format(
        //                "Type '{0}' must have the following constructor: T(Binding, EndpointAddress).",
        //                clientType.FullName));
        //    var instance = constructor.Invoke(new object[] { binding, endpointAddress });
        //    var clientBase = (TClientBase)instance;
        //    return clientBase;
        //}

        //private TClientBase CreateClient<TChannel, TClientBase>(string serviceUri)
        //    where TChannel : class
        //    where TClientBase : ClientBase<TChannel>
        //{
        //    var serviceConfiguration = configurationSyncProvider.GetServiceConfiguration();

        //    var binding = GetDefaultBinding();
        //    var endpointAddress = GetEndpointAddress(serviceConfiguration.Uri, serviceUri);

        //    var clientBase = GetClient<TChannel, TClientBase>(binding, endpointAddress);

        //    if (clientBase.ClientCredentials == null)
        //        throw new InvalidOperationException("Cannot configure null client credentials.");

        //    clientBase.ClientCredentials.UserName.UserName = serviceConfiguration.UserName;
        //    clientBase.ClientCredentials.UserName.Password = serviceConfiguration.Password;

        //    return clientBase;
        //}

        private static void SetCredentials<T>(ClientBase<T> clientBase, string userName, string password) where T : class
        {
            if (null == clientBase.ClientCredentials)
            {
                throw new NullReferenceException("Credentials may not be null");
            }

            clientBase.ClientCredentials.UserName.UserName = userName;
            clientBase.ClientCredentials.UserName.Password = password;
        }
    }

    //public interface IConfigurationSyncProvider
    //{
    //    [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = " ")]
    //    ServiceConfiguration GetServiceConfiguration();
    //}

    //public class ServiceConfiguration
    //{
    //    [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Justification = " ")]
    //    public string Uri { get; set; }

    //    public string UserName { get; set; }

    //    public string Password { get; set; }
    //}
}
