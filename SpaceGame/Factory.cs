using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	abstract class Factory : Building
	{
		public Resource ResourseType { get; set; }
		public int Level { get; set; }
		public Dictionary<int, Resource> PricePerLevel { get; set; } = new Dictionary<int, Resource>
		{
			[0] = new Stone(10),
			[1] = new Wood(8)
		};
		public Dictionary<int, Resource> ResourceKey { get; set; }

		public Factory()
		{
			this.Price[0].Amount = 50;
			this.Price[1].Amount = 50;
		}
		public void Mine()
		{
			ResourceKey = new Dictionary<int, Resource> { [ResourseType.Key] = ResourseType };
			if (this.Colony.Planet.Storage.RemoveFromStorage(ResourceKey))
			{
				this.Colony.Planet.Space.Storage.AddToStorage(ResourseType);
				//return true;
			} else if (this.Colony.Planet.Storage.Store[ResourseType.Key].Amount > 0)
			{
				Resource res = Colony.Planet.Storage.Store[ResourseType.Key];
				this.Colony.Planet.Storage.Clear(res);
				this.Colony.Planet.Space.Storage.AddToStorage(res);
				//return true;
			}
			//return false;
		}

		public bool Upgrade()
		{
			if (this.Colony.Planet.Space.Storage.RemoveFromStorage(PricePerLevel))
			{
				this.PricePerLevel[0].Amount =(int)(this.PricePerLevel[0].Amount * 3/2);
				this.PricePerLevel[1].Amount = (int)(this.PricePerLevel[1].Amount * 3 / 2);
				this.Level++;
				this.ResourseType.Amount *= 2;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
