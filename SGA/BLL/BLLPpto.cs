using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLPpto
    {
		private readonly static BLLPpto _instance = new BLLPpto();

		public static BLLPpto Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLPpto()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
