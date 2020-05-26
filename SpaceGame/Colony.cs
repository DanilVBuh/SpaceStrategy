using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	class Colony
	{
		public Planet Planet { get; set; }
		public Dictionary<int, ICollection<Building>> Buildings { get; set; } = new Dictionary<int, ICollection<Building>>
		{
			[0] = new List<Building>(),
			[1] = new List<Building>()
		};
		public Colony(Planet planet)
		{
			this.Planet = planet;
		}
		public int Size { get; set; } = 10;

		public string Name { get; set; }

		public int AmountOfBuildings()
		{
			int sum = 0;
			foreach(int k in Buildings.Keys)
			{
				sum += Buildings[k].Count;
			}
			return sum;
		}

		public bool Build(Building building)
		{
			if (this.AmountOfBuildings() < Size)
			{
				building.Colony = this;

				if (Planet.Space.Storage.RemoveFromStorage(building.Price))
				{
					building.Name += (Buildings[building.Key].Count + 1);
					Buildings[building.Key].Add(building);
					return true;
				}
				return false;
			}
			else return false;


		}
	}
}
