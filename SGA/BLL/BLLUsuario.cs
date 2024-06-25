using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLUsuario
	{
		private readonly static BLLUsuario _instance = new BLLUsuario();

		public static BLLUsuario Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLUsuario()
		{
			//Implent here the initialization of your singleton
		}
	}


}
