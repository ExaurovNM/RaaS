// -----------------------------------------------------------------------
// <copyright file="DeviceRepositoryService.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RadiantRFID.RaaS.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;

    using RadiantRFID.RaaS.Tools.DeviceRepositoryService;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DeviceRepositoryRMSService
    {
        public IList<Device> GetDevices(NetworkCredential credential)
        {
            var client = new DeviceRepositoryClient();
            client.ClientCredentials.UserName.UserName = credential.UserName;
            client.ClientCredentials.UserName.Password = credential.Password;

            return client.GetItems().ToList();
        }
    }
}
