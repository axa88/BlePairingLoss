using System;


namespace BlePairingLoss.BLE
{
	internal static class UuIds
	{
		internal const ushort RootMenu = 0xe000;

		internal const ushort MonitorServiceId = 0xe010;
		internal const ushort SecurityPinId = 0xe020;
		internal const ushort IgnitionConfigId = 0xe030;

		internal static Guid GetUuid(this ushort id) => new($"{"deadface-deaf-dead-face-decafcaf"}{id:x4}");
	}
}
