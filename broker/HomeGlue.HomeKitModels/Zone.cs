using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class Zone {
		public string Name { get; set; }
		public Guid UniqueIdentifier { get; set; }
		public ICollection<Room> Rooms { get; set; }
	}
}