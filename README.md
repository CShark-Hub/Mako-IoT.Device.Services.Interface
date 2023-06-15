# Mako-IoT.Device.Services.Interface
Interfaces for most of MAKO IoT components. Start building your app here :)

## Device
See [Mako-IoT.Device](https://github.com/CShark-Hub/Mako-IoT.Device)

IDevice, IDeviceBuilder, IDeviceStartBehavior

## Configuration
See [Mako-IoT.Device.Services.Configuration](https://github.com/CShark-Hub/Mako-IoT.Device.Services.Configuration)

IConfigurationService

## Communication
_ICommunicationService_ abstracts data transport logic. Currently MAKO-IoT provides [MQTT implementation](https://github.com/CShark-Hub/Mako-IoT.Device.Services.Mqtt).
### Example
```c#
//attach message received handler
_communicationService.MessageReceived += OnMessageReceived;

_communicationService.Connect(topicsToSubscribe);

//publish message
_communicationService.Publish(message, topic);

//send message to recipient
_communicationService.Send(message, recipient);

_communicationService.Disconnect();

internal void OnMessageReceived(object sender, EventArgs e)
{
  var message = (string)((ObjectEventArgs)e).Data;
  //[...]
}
```

## Data Providers
See [Mako-IoT.Device.Services.DataProviders](https://github.com/CShark-Hub/Mako-IoT.Device.Services.DataProviders)

IDataProvider

## Message Bus
See [Mako-IoT.Device.Services.Messaging](https://github.com/CShark-Hub/Mako-IoT.Device.Services.Messaging)

IMessageBus, IConsumer, ConsumeContext, ConsumeStrategy

## Networking
_INetworkProvider_ provides basic network connectivity functions. Currently MAKO-IoT provides [WiFi implementation](https://github.com/CShark-Hub/Mako-IoT.Device.Services.WiFi).
### Example
```c#
if (!_networkProvider.IsConnected)
{
    _networkProvider.Connect();
    if (!_networkProvider.IsConnected)
        throw new NotConnectedException("Could not connect to network");
}
```

## Scheduler
See [Mako-IoT.Device.Services.Scheduler](https://github.com/CShark-Hub/Mako-IoT.Device.Services.Scheduler)

IScheduler, ITask

## Storage
_IStorageService_ provides persistent storage functions. Currently MAKO-IoT provides [NVS Flash storage implementation](https://github.com/CShark-Hub/Mako-IoT.Device.Services.FileStorage).
### Example
```c#
bool fileExists = _storage.FileExists(fileName);

//read file
contents = _storage.ReadFile(fileName);

//write to file
_storage.WriteToFile(fileName, contents);

//delete file
_storage.DeleteFile(file);
```

