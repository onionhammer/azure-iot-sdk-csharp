using Microsoft.Azure.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeviceExplorer
{
    class DevicesProcessor
    {
        private List<DeviceEntity> listOfDevices;
        private RegistryManager registryManager;
        private String iotHubConnectionString;

        public DevicesProcessor(string iotHubConnenctionString)
        {
            this.listOfDevices = new List<DeviceEntity>();
            this.iotHubConnectionString = iotHubConnenctionString;
            this.registryManager = RegistryManager.CreateFromConnectionString(iotHubConnectionString);
        }

        public async Task<List<DeviceEntity>> GetDevices()
        {
            var query = registryManager.CreateQuery("select * from devices");
            var result = new List<DeviceEntity>();

            while (query.HasMoreResults)
            {
                foreach (var deviceJson in await query.GetNextAsJsonAsync())
                {
                    var device = JsonConvert.DeserializeObject<DeviceRecord>(deviceJson);

                    var deviceEntity = new DeviceEntity
                    {

                        Id = device.DeviceId,
                        ConnectionState = device.ConnectionState,
                        LastActivityTime = device.LastActivityTime.LocalDateTime,// DateTime.SpecifyKind(device.LastActivityTime, DateTimeKind.Utc).ToLocalTime(),
                        LastConnectionStateUpdatedTime = device.StatusUpdateTime.LocalDateTime,// DateTime.SpecifyKind(device.ConnectionStateUpdatedTime, DateTimeKind.Utc).ToLocalTime(),
                        LastStateUpdatedTime = device.StatusUpdateTime.LocalDateTime ,//DateTime.SpecifyKind(device.StatusUpdatedTime, DateTimeKind.Utc).ToLocalTime(),
                        MessageCount = device.CloudToDeviceMessageCount,
                        State = device.Status
                    };

                    result.Add(deviceEntity);
                }
            }

            return result;
        }

        private String CreateDeviceConnectionString(Device device)
        {
            StringBuilder deviceConnectionString = new StringBuilder();

            var hostName = String.Empty;
            var tokenArray = iotHubConnectionString.Split(';');
            for (int i = 0; i < tokenArray.Length; i++)
            {
                var keyValueArray = tokenArray[i].Split('=');
                if (keyValueArray[0] == "HostName")
                {
                    hostName =  tokenArray[i] + ';';
                    break;
                }
            }

            if (!String.IsNullOrWhiteSpace(hostName))
            {
                deviceConnectionString.Append(hostName);
                deviceConnectionString.AppendFormat("DeviceId={0}", device.Id);

                if (device.Authentication != null)
                {
                    if ((device.Authentication.SymmetricKey != null) && (device.Authentication.SymmetricKey.PrimaryKey != null))
                    {
                        deviceConnectionString.AppendFormat(";SharedAccessKey={0}", device.Authentication.SymmetricKey.PrimaryKey);
                    }
                    else
                    {
                        deviceConnectionString.AppendFormat(";x509=true");
                    }
                }
            }
            
            return deviceConnectionString.ToString();
        }
        private class DeviceRecord
        {
            public string DeviceId { get; set; }
            public string ConnectionState { get; set; }
            public DateTimeOffset LastActivityTime { get; set; }
            public DateTimeOffset StatusUpdateTime { get; set; }
            public int CloudToDeviceMessageCount { get; set; }
            public string Status { get; set; }
            public string AuthenticationType { get; set; }
        }
    }
}
