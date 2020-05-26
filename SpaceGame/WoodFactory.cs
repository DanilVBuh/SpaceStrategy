using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
	class WoodFactory : Factory
	{
		public WoodFactory()
		{
			Key = 1;
			Name = "WF";
			ResourseType = new Wood(4);
		}
	}
}
