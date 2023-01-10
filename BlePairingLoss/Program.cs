using System;
using System.Threading;

using BlePairingLoss.BLE;


namespace BlePairingLoss
{
	public static class Program
	{
		public static void Main()
		{
			Thread.Sleep(TimeSpan.FromSeconds(3)); // recover from a hang

			GattService gattService = new();
			var gattLocalService = gattService.Service;
			Ignitions ignitions = new Ignitions(gattService.Service);

			gattService.Advertise();

			Thread.Sleep(Timeout.Infinite);
		}
	}
}