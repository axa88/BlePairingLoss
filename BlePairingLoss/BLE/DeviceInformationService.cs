using System;

using nanoFramework.Device.Bluetooth;
using nanoFramework.Device.Bluetooth.GenericAttributeProfile;


namespace BlePairingLoss.BLE
{
	/// <summary>
	/// Device Information Service.
	/// Information about the device.
	/// </summary>
	public class DeviceInformationServiceService
	{
		private readonly GattLocalService _deviceInformationService;

		/// <summary>
		/// Create a new Device Information Service on Provider using supplied string.
		/// If a string is null the Characteristic will not be included in service.
		/// </summary>
		/// <param name="provider"></param>
		/// <param name="manufacturer"></param>
		/// <param name="modelNumber"></param>
		/// <param name="serialNumber"></param>
		/// <param name="hardwareRevision"></param>
		/// <param name="firmwareRevision"></param>
		/// <param name="softwareRevision"></param>
		public DeviceInformationServiceService(GattServiceProvider provider, string manufacturer, string modelNumber = null, string serialNumber = null, string hardwareRevision = null, string firmwareRevision = null, string softwareRevision = null)
		{
			// Add new Device Information Service to provider
			_deviceInformationService = provider.AddService(GattServiceUuids.DeviceInformation);

			CreateReadStaticCharacteristic(GattCharacteristicUuids.ManufacturerNameString, manufacturer);
			CreateReadStaticCharacteristic(GattCharacteristicUuids.ModelNumberString, modelNumber);
			CreateReadStaticCharacteristic(GattCharacteristicUuids.SerialNumberString, serialNumber);
			CreateReadStaticCharacteristic(GattCharacteristicUuids.HardwareRevisionString, hardwareRevision);
			CreateReadStaticCharacteristic(GattCharacteristicUuids.FirmwareRevisionString, firmwareRevision);
			CreateReadStaticCharacteristic(GattCharacteristicUuids.SoftwareRevisionString, softwareRevision);
		}

		/// <summary>
		/// Create static Characteristic if not null.
		/// </summary>
		/// <param name="uuid">Characteristic UUID</param>
		/// <param name="data">string data or null</param>
		private void CreateReadStaticCharacteristic(Guid uuid, string data)
		{
			if (data != null)
			{
				// Create data buffer
				var writer = new DataWriter();
				writer.WriteString(data);

				_deviceInformationService.CreateCharacteristic(uuid, new GattLocalCharacteristicParameters { CharacteristicProperties = GattCharacteristicProperties.Read, StaticValue = writer.DetachBuffer() });
			}
		}
	}
}
