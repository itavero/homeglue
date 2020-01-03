using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class Characteristic {
		public Guid UniqueIdentifier { get; set; }
		public ICollection<CharacteristicProperty> Properties { get; set; }
		public object Value { get; set; }
		public CharacteristicMetadata Metadata { get; set; }
		public Service Service { get; set; }
	}
}