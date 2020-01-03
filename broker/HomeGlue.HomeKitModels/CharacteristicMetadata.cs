using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class CharacteristicMetadata {
		public string ManufacturerDescription { get; set; }
		public ICollection<UInt64> ValidValues { get; set; }
		public object MinimumValue { get; set; }
		public object MaximumValue { get; set; }
		public object StepValue { get; set; }
		public CharacteristicMetadataFormat? Format { get; set; }
		public CharacteristicMetadataUnit? Units { get; set; }
	}
}