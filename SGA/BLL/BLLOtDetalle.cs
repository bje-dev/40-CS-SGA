using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLOtDetalle
    {
		private readonly static BLLOtDetalle _instance = new BLLOtDetalle();

		public static BLLOtDetalle Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLOtDetalle()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
