using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class Service {
		public string Name { get; set; }
		public Guid UniqueIdentifier { get; set; }
		public string ServiceType { get; set; }
		public bool IsPrimaryService { get; set; }
		public bool IsUserInteractive { get; set; }
		public string AssociatedServiceType { get; set; }
		public ICollection<Service> LinkedServices { get; set; }
		public Accessory Accessory { get; set; }
	}
}