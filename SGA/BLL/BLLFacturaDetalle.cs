using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLFacturaDetalle
    {
		private readonly static BLLFacturaDetalle _instance = new BLLFacturaDetalle();

		public static BLLFacturaDetalle Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLFacturaDetalle()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
