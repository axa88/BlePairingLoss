using System;
using System.Diagnostics;

using nanoFramework.Device.Bluetooth;
using nanoFramework.Device.Bluetooth.GenericAttributeProfile;
using nanoFramework.Runtime.Native;


namespace BlePairingLoss.BLE
{
	internal class GattService
	{
		private readonly GattServiceProvider _serviceProvider;

		internal GattService()
		{
			//The GattServiceProvider is used to create and advertise the primary service definition.
			//An extra device information service will be automatically created.
			var serviceProviderResult = GattServiceProvider.Create(UuIds.MonitorServiceId.GetUuid());
			if (serviceProviderResult.Error != BluetoothError.Success)
				return;

			_serviceProvider = serviceProviderResult.ServiceProvider;
			// Get created Primary service from provider
			Service = _serviceProvider.Service; // needed before changing device info?

			DeviceInformationServiceService _ = new(_serviceProvider, "TradeCraftInc", "motoAppAratus", "x001", new Version(0, 0, 0, 0).ToString(), SystemInfo.Version.ToString(), new Version(0,0,0,0).ToString());
		}

		internal GattLocalService Service { get; }

		internal void Advertise()
		{
			// Once all the Characteristics have been created advertise the Service.
			_serviceProvider.StartAdvertising(new GattServiceProviderAdvertisingParameters
			{
				DeviceName = "motoAppAratus",
				IsConnectable = true,
				IsDiscoverable = true,
				//ServiceData = new(new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 })
			});

			#if DEBUG
			if (_serviceProvider.AdvertisementStatus == GattServiceProviderAdvertisementStatus.StartedWithoutAllAdvertisementData)
				Debug.WriteLine($"{_serviceProvider.AdvertisementStatus}");
			#else
			#endif
		}
	}
}
