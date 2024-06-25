using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLFactura
    {
		private readonly static BLLFactura _instance = new BLLFactura();

		public static BLLFactura Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLFactura()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
