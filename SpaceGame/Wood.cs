using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	class Wood : Resource
	{
		public Wood(int amount) : base(amount)
		{
			Key = 1;
			Type = "wood";
		}
	}
}
