using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class Accessory {
		public string Name { get; set; }
		public Guid UniqueIdentifier { get; set; }
		public AccessoryCategory Category { get; set; }
		public Room Room { get; set; }
		public ICollection<AccessoryProfile> Profiles { get; set; }
		// NOTE: CameraProfiles purposely left out.
		public bool IsReachable { get; set; }
		public bool IsBlocked { get; set; }
		public bool SupportsIdentify { get; set; }
		public ICollection<Service> Services { get; set; }
		public bool IsBridged { get; set; }
		public ICollection<Guid> UniqueIdentifiersForBridgedAccessories { get; set; }
		public string FirmwareVersion { get; set; }
		public string Manufacturer { get; set; }
		public string Model { get; set; }
	}
}