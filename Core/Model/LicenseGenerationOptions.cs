﻿using System.Collections.Generic;

namespace WaveTech.Scutex.Model
{
	/// <summary>
	/// This class determines how a license key is generated by the generation system.
	/// </summary>
	public class LicenseGenerationOptions
	{
		/// <summary>
		/// The License Key type to encode in the generated license keys.
		/// </summary>
		public LicenseKeyTypes LicenseKeyType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string HardwareFingerprint { get; set; }


		/// <summary>
		/// The LicenseSet id
		/// </summary>
		public int LicenseSetId { get; set; }

		public Dictionary<string, string> CustomData { get; set; }
	}
}