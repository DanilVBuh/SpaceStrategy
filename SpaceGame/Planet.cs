using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	class Planet
	{
		public Space Space { get; set; }
		public Storage Storage { get; set; }
		public Colony Colony { get; set; }
		public Dictionary<int, Resource> Price { get; set; } = new Dictionary<int, Resource>
		{
			[0] = new Stone(125),
			[1] = new Wood(100)
		};
		public Planet(string name)
		{
			Storage.Store[0].Amount = 500;
			Storage.Store[1].Amount = 400;
			this.Colony = new Colony(this);
			this.Name = name;
		}
		public string Name { get ; }

	}
}
