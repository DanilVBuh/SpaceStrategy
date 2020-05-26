using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	class Space
	{
		public Storage Storage { get; set; } = new Storage();
		public int AmountOfPlanet { get; set; } = 0;
		public ICollection<Planet> Planets = new List<Planet>();
		private Planet Planet;

		public Space()
		{
			this.Storage.Store[0].Amount = 1000;
			this.Storage.Store[1].Amount = 800;
		}

		public bool ExplorePlanet(string name)
		{
			if (name != "" && Planets.All(p => p.Name != name))
			{
				Planet = new Planet(name);
				Planet.Space = this;
				if (this.Storage.RemoveFromStorage(Planet.Price))
				{
					Planets.Add(Planet);
					return true;
				}
				return false;
			}
			else
			{
				return false;
			}

		}

	}
}
