using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

	public sealed class BLLUnidad
    {
		private readonly static BLLUnidad _instance = new BLLUnidad();

		public static BLLUnidad Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLUnidad()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
