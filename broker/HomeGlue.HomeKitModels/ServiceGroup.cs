using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class ServiceGroup {
		public string Name { get; set; }
		public Guid UniqueIdentifier { get; set; }
		public ICollection<Service> Services { get; set; }
	}
}