using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Text;


namespace BlePairingLoss
{
	internal static class Utility
	{
		internal static bool BytesEqual(byte[] b1, byte[] b2)
		{
			if (b1 == b2) return true;
			if (b1 == null || b2 == null) return false;
			if (b1.Length != b2.Length) return false;
			for (var i = 0; i < b1.Length; i++)
				if (b1[i] != b2[i])
					return false;

			return true;
		}

		internal static void PrintArray(byte[] bytes)
		{
			if (bytes == null)
				Debug.WriteLine("array is null");
			else
				foreach (var b in bytes)
					Debug.Write($"{b} ");

			Debug.WriteLine("");
		}

		internal static ArrayList GetEnumValues(Enum enumeration)
		{
			ArrayList enumerations = new();
			foreach (var fieldInfo in enumeration.GetType().GetFields(BindingFlags.Static | BindingFlags.Public))
				enumerations.Add((Enum)fieldInfo.GetValue(enumeration));
			return enumerations;
		}

		internal static ArrayList GetEnumValues(Type enumeration)
		{
			ArrayList enumerations = new();
			foreach (var fieldInfo in enumeration.GetFields(BindingFlags.Static | BindingFlags.Public))
				enumerations.Add((Enum)fieldInfo.GetValue(enumeration));
			return enumerations;
		}

		internal static void CopyFields(this object source, object destination)
		{
			// If any this null throw an exception
			if (source == null || destination == null)
				throw new Exception("Source or/and Destination Objects are null");

			foreach (var fieldInfo in source.GetType().GetFields())
			{
				var field = destination.GetType().GetField(fieldInfo.Name);
				field?.SetValue(destination, fieldInfo.GetValue(source));
			}
		}
	}
}
