using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

	public sealed class BLLEstadoSolicitud
    {
		private readonly static BLLEstadoSolicitud _instance = new BLLEstadoSolicitud();

		public static BLLEstadoSolicitud Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLEstadoSolicitud()
		{
			//Implent here the initialization of your singleton
		}
	}

}
