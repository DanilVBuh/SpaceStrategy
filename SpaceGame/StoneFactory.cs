using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	class StoneFactory : Factory
	{
		public StoneFactory()
		{
			Key = 0;
			Name = "SF";
			ResourseType = new Stone(4);
		}
	}
}
