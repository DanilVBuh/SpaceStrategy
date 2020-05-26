using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	abstract class Building
	{
		public Dictionary<int, Resource> Price { get; set; } = new Dictionary<int, Resource>
		{
			[0] = new Stone(30),
			[1] = new Wood(20)
		};
		public int Key { get; set; }
		public Colony Colony { get; set; }
		public string Name { get; set; }

	}
}
