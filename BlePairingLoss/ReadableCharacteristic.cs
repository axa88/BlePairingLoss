using System.Diagnostics;

using BlePairingLoss.BLE;
using BlePairingLoss.BLE.Characteristic;

using nanoFramework.Device.Bluetooth;
using nanoFramework.Device.Bluetooth.GenericAttributeProfile;

using static nanoFramework.Device.Bluetooth.GenericAttributeProfile.GattCharacteristicProperties;


namespace BlePairingLoss
{
	internal abstract class ReadableCharacteristic
	{
		private readonly GattLocalService _gattService;
		protected GattLocalCharacteristic Characteristic;

		internal ReadableCharacteristic(GattLocalService gattService) => _gattService = gattService;

		protected internal virtual IReadBytes Value { get; set; }

		protected string GetName() => GetType().Name;

		protected bool Initialize(string userDescription, ushort uuid, GattPresentationFormatParameters formatParameters = null, GattCharacteristicProperties gattCharacteristicProperties = None)
		{
			var parameters = new GattLocalCharacteristicParameters
			{
				CharacteristicProperties = gattCharacteristicProperties | Read,
				UserDescription = userDescription
			};

			if (formatParameters != null)
				parameters.CreateGattPresentationFormat(formatParameters.GattPresentationFormatType, formatParameters.Exponent, formatParameters.Unit, (byte)Namespace.Sig, (byte)Description.Unknown);
			var result = _gattService.CreateCharacteristic(uuid.GetUuid(), parameters);

			if (result.Error != BluetoothError.Success)
				return false;

			Characteristic = result.Characteristic;
			Characteristic.ReadRequested += (_, args) =>
			{
				DataWriter dw = new();
				dw.WriteBytes(Value.ReadBytes());
				args.GetRequest().RespondWithValue(dw.DetachBuffer());

				#if DEBUG
				Debug.WriteLine($"{GetName()} ReadRequested: ");
				Utility.PrintArray(Value.ReadBytes());
				#else
				#endif
			};

			Uuid = uuid;
			return true;
		}

		protected internal ushort Uuid { get; private set; }
	}
}