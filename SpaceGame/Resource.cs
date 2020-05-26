using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	abstract class Resource
	{
		protected Resource(int amount)
		{
			Amount = amount;
		}

		public int Key { get; set; }
		public int Amount { get; set; }
		public string Type { get; set; }

	}
}
