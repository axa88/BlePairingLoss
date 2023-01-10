using BlePairingLoss.BLE;

using nanoFramework.Device.Bluetooth.GenericAttributeProfile;


namespace BlePairingLoss
{
	internal class Ignitions : ReadableCharacteristic
	{
		internal Ignitions(GattLocalService gattService) : base(gattService)
		{
			var presentationFormat = new GattPresentationFormatParameters(GattPresentationFormatTypes.Struct, default, (ushort)Unit.Unitless);
			Initialize("test", UuIds.IgnitionConfigId, presentationFormat);
		}
	}
}