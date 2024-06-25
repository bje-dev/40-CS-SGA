using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

	public sealed class BLLPrioridad
    {
		private readonly static BLLPrioridad _instance = new BLLPrioridad();

		public static BLLPrioridad Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLPrioridad()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
