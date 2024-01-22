using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationLibraryDemo
{
    public class Rectangle
    {
		private int _length;

		public int Length
		{
			get { return _length; }
			set { _length = value; }
		}


		private int _width;

		public int Width
		{
			get { return _width; }
			set { _width = value; }
		}


		public int CalculateArea()
		{
			return Length * Width;
		}

	}
}
