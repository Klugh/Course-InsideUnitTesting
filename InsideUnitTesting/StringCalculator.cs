using System;
using System.Collections.Generic;
using System.Text;

namespace InsideUnitTesting
{
    public class StringCalculator
    {
		public string CreateNumString(int x, int y)
		{
			return string.Format("{0},{1}", x, y);
		}
    }
}
