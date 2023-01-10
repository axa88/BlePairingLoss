namespace BlePairingLoss.BLE
{
	/// <summary>
	/// The Name Space field is used to identify the organization that is responsible for defining the enumerations for the description field
	/// </summary>
	public enum Namespace
	{
		/// <summary>
		/// Unknown
		/// </summary>
		Unknown,
		/// <summary>
		/// Bluetooth SIG Assigned Numbers
		/// </summary>
		Sig
	}

#pragma warning disable CA1027 // Mark enums with FlagsAttribute
	public enum Description : ushort
#pragma warning restore CA1027 // Mark enums with FlagsAttribute
	{
		Unknown = 0x0000,
		Auxiliary = 0x0108,
		Back = 0x0101,
		Backup = 0x0107,
		Bottom = 0x0103,
		External = 0x0110,
		Flash = 0x010A,
		Front = 0x0100,
		Inside = 0x010B,
		Internal = 0x010F,
		Left = 0x010D,
		Lower = 0x0105,
		Main = 0x0106,
		Outside = 0x010C,
		Right = 0x010E,
		Supplementary = 0x0109,
		Top = 0x0102,
		Upper = 0x0104,
		First = 0x0001,
		Second = 0x0002,
		Third = 0x0003,
		Fourth = 0x0004,
		Fifth = 0x0005,
		Sixth = 0x0006,
		Seventh = 0x0007,
		Eighth = 0x0008,
		Ninth = 0x0009,
		Tenth = 0x000a,
		Eleventh = 0x000b,
		Twelfth = 0x000c,
		Thirteenth = 0x000d,
		Fourteenth = 0x000e,
		Fifteenth = 0x000f,
		Sixteenth = 0x0010,
		Seventeenth = 0x0011,
		Eightieth = 0x0012,
		Ninetieth = 0x0013,
		Twentieth = 0x0014
	}

	public enum Unit : ushort
	{
		Unitless = 0x2700,
		LengthMeters = 0x2701,
		MassKilogram = 0x2702,
		TimeSecond = 0x2703,
		ElectricCurrentAmpere = 0x2704,
		ThermodynamicTemperatureKelvin = 0x2705,
		AmountOfSubstanceMole = 0x2706,
		LuminousIntensityCandela = 0x2707,
		AreaSquareMeters = 0x2710,
		VolumeCubicmeters = 0x2711,
		VelocityMetersPerSecond = 0x2712,
		AccelraionMetersPerSecondSquared = 0x2713,
		WavenumberReciprocalMeter = 0x2714,
		DensityKilogramPerCubicMeter = 0x2715,
		SurfaceDensityKilogramPerSquareMeter = 0x2716,
		SpecificVolumeCubicMeterPerKilogram = 0x2717,
		CurrentDensityAmperePerSquareMeter = 0x2718,
		MagneticFieldStrengthAmperePerMeter = 0x2719,
		AmountConcentrationMolePerCubicMeter = 0x271a,
		MassConcentrationKilogramPerCubicMeter = 0x271b,
		LuminanceCandelaPerSquareMeter = 0x271c,
		RefractiveIndex = 0x271d,
		RelativePermeability = 0x271e,
		PlaneAngleRadian = 0x2720,
		SolidAngleSteradian = 0x2721,
		FrequencyHertz = 0x2722,
		ForceNewton = 0x2723,
		PressurePascal = 0x2724,
		EnergyJoule = 0x2725,
		PowerWatt = 0x2726,
		ElectricChargeCoulomb = 0x2727,
		ElectricPotentialDifferenceVolt = 0x2728,
		CapacitanceFarad = 0x2729,
		ElectricResistanceOhm = 0x272a,
		ElectricConductanceSiemens = 0x272b,
		MagneticFluxWeber = 0x272c,
		MagneticFluxDensityTesla = 0x272d,
		InductanceHenry = 0x272e,
		CelsiusTemperatureDegreeCelsius = 0x272f,
		LuminousFluxLumen = 0x2730,
		IlluminanceLux = 0x2731,
		ActivityReferredToARadionuclideBecquerel = 0x2732,
		AbsorbedDoseGray = 0x2733,
		DoseEquivalentSievert = 0x2734,
		CatalyticActivityKatal = 0x2735,
		DynamicViscosityPascalSecond = 0x2740,
		MomentOfForceNewtonMeter = 0x2741,
		SurfaceTensionNewtonPerMeter = 0x2742,
		AngularVelocityRadianPerSecond = 0x2743,
		AngularAccelerationRadianPerSecondSquared = 0x2744,
		HeatFluxDensityWattPerSquareMeter = 0x2745,
		HeatCapacityJoulePerKelvin = 0x2746,
		SpecificHeatCapacityJoulePerKilogramKelvin = 0x2747,
		SpecificEnergyJoulePerKilogram = 0x2748,
		ThermalConductivityWattPerMeterKelvin = 0x2749,
		EnergyDensityJoulePerCubicMeter = 0x274a,
		ElectricFieldStrengthVoltPerMeter = 0x274b,
		ElectricChargeDensityCoulombPerCubicMeter = 0x274c,
		SurfaceChargeDensityCoulombPerSquareMeter = 0x274d,
		ElectricFluxDensityCoulombPerSquareMeter = 0x274e,
		PermittivityFaradPerMeter = 0x274f,
		PermeabilityHenryPerMeter = 0x2750,
		MolarEnergyJoulePerMole = 0x2751,
		MolarEntropyJoulePerMoleKelvin = 0x2752,
		ExposureCoulombPerKilogram = 0x2753,
		AbsorbedDoseRateGrayPerSecond = 0x2754,
		RadiantIntensityWattPerSteradian = 0x2755,
		RadianceWattPerSquareMeterSteradian = 0x2756,
		CatalyticActivityConcentrationKatalPerCubicMeter = 0x2757,
		TimeMinute = 0x2760,
		TimeHour = 0x2761,
		TimeDay = 0x2762,
		PlaneAngleDegree = 0x2763,
		PlaneAngleMinute = 0x2764,
		PlaneAngleSecond = 0x2765,
		AreaHectare = 0x2766,
		VolumeLitre = 0x2767,
		MassTonne = 0x2768,
		PressureBar = 0x2780,
		PressureMillimetreOfMercury = 0x2781,
		LengthÅngström = 0x2782,
		LengthNauticalMile = 0x2783,
		AreaBarn = 0x2784,
		VelocityKnot = 0x2785,
		LogarithmicRadioQuantityNeper = 0x2786,
		LogarithmicRadioQuantityBel = 0x2787,
		LengthYard = 0x27a0,
		LengthParsec = 0x27a1,
		LengthInch = 0x27a2,
		LengthFoot = 0x27a3,
		LengthMile = 0x27a4,
		PressurePoundForcePerSquareInch = 0x27a5,
		VelocityKilometerPerHour = 0x27a6,
		VelocityMilePerHour = 0x27a7,
		AngularVelocityRevolutionPerMinute = 0x27a8,
		EnergyGramCalorie = 0x27a9,
		EnergyKilogramCalorie = 0x27aa,
		EnergyKilowattHour = 0x27ab,
		ThermodynamicTemperatureDegreeFahrenheit = 0x27ac,
		Percentage = 0x27ad,
		PerMile = 0x27ae,
		PeriodBeatsPerMinute = 0x27af,
		ElectricChargeAmpereHours = 0x27b0,
		MassDensityMilligramPerDeciliter = 0x27b1,
		MassDensityMilliMolePerLiter = 0x27b2,
		TimeYear = 0x27b3,
		TimeMonth = 0x27b4,
		ConcentrationCountPerCubicMeter = 0x27b5,
		IrradianceWattPerSquareMeter = 0x27b6,
		MilliliterPerKilogramPerMinute = 0x27b7,
		MassPound = 0x27b8,
		MetabolicEquivalent = 0x27b9,
		StepPerMinute = 0x27ba,
		StrokePerMinute = 0x27bc,
		PaceKilometerPerMinute = 0x27bd,
		LuminousEfficacyLumenPerWatt = 0x27be,
		LuminousEnergyLumenHour = 0x27bf,
		LuminousExposureLuxHour = 0x27c0,
		MassFlowGramPerSecond = 0x27c1,
		VolumeFlowLiterPerSecond = 0x27c2,
		SoundPressureDecibel = 0x27c3,
		PartsPerMillion = 0x27c4,
		PartsPerBillion = 0x27c5
	}

	public class GattPresentationFormatParameters
	{
		public GattPresentationFormatParameters(byte gattPresentationFormatType, int exponent, ushort unit)
		{
			GattPresentationFormatType = gattPresentationFormatType;
			Exponent = exponent;
			Unit = unit;
		}

		public GattPresentationFormatParameters() { }

		protected internal byte GattPresentationFormatType { get; }
		protected internal int Exponent { get; }
		protected internal ushort Unit { get; }
	}
}
