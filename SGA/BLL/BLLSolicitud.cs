using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

	public sealed class BLLSolicitud
    {
		private readonly static BLLSolicitud _instance = new BLLSolicitud();

		public static BLLSolicitud Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLSolicitud()
		{
			//Implent here the initialization of your singleton
		}
	}


	
}
