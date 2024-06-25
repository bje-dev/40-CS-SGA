using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLRepuesto
    {
		private readonly static BLLRepuesto _instance = new BLLRepuesto();

		public static BLLRepuesto Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLRepuesto()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
