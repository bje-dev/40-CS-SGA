using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

	public sealed class BLLMarca
    {
		private readonly static BLLMarca _instance = new BLLMarca();

		public static BLLMarca Current
		{
			get
			{
				return _instance;
			}
		}

		private BLLMarca()
		{
			//Implent here the initialization of your singleton
		}
	}

	
}
