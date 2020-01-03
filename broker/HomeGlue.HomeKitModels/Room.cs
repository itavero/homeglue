using System;
using System.Collections.Generic;

namespace HomeGlue.HomeKitModels {
	public class Room {
		public string Name { get; set; }
		public Guid UniqueIdentifier { get; set; }
		public ICollection<Accessory> Accessories { get; set; }
	}
}