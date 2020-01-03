using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class AccessoryProfile {
		public Guid UniqueIdentifier { get; set; }
		public Accessory Accessory { get; set; }
		public ICollection<Service> Services { get; set; }
	}
}