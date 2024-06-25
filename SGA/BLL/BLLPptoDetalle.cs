using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLPptoDetalle
    {
		private readonly static BLLPptoDetalle _instance = new BLLPptoDetalle();

		public static BLLPptoDetalle Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLPptoDetalle()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
