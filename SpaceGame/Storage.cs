using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	class Storage
	{
		public Dictionary<int, Resource> Store { get; set; } = new Dictionary<int, Resource>
		{
			[0] = new Stone(0),
			[1] = new Wood(0)
		};
		public void AddToStorage(Resource resource)
		{
			Store[resource.Key].Amount += resource.Amount;
		}
		public void Clear(Resource resource)
		{
			Store[resource.Key].Amount = 0;
		}
		public bool RemoveFromStorage(Dictionary<int, Resource> price)
		{
			foreach(int k in price.Keys)
			{
				if (Store[k].Amount < price[k].Amount)
				{
					return false;
				}
			}

			foreach (int k in price.Keys)
			{
				Store[k].Amount -= price[k].Amount;
			}
			return true;
		}
	}
}
