using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLOt
    {
		private readonly static BLLOt _instance = new BLLOt();

		public static BLLOt Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLOt()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
