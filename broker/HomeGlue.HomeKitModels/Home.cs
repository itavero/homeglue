using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class Home {
		public string Name { get; set; }
		public Guid UniqueIdentifier { get; set; }
		public ICollection<Room> Rooms { get; set; }
		public ICollection<Zone> Zones { get; set; }
		public ICollection<Accessory> Accessories { get; set; }
		public ICollection<ServiceGroup> ServiceGroups { get; set; }
		
	}
}