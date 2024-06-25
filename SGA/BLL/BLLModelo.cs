using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


	public sealed class BLLModelo
    {
		private readonly static BLLModelo _instance = new BLLModelo();

		public static BLLModelo Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLModelo()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
