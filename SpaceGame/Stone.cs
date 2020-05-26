using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	class Stone : Resource
	{
		public Stone(int amount):base(amount)
		{
			Key = 0;
			Type = "stone";
		}
	}
}
