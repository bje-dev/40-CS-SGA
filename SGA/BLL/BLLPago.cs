using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLPago
    {
		private readonly static BLLPago _instance = new BLLPago();

		public static BLLPago Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLPago()
		{
			//Implent here the initialization of your singleton
		}
	}


}
