using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1+ 2 + 3 + 4 + .... + N <105 請問 N 是多少 ?
			int current = 0;
			int restriction = 105;
			int count = 0;
			while (count < restriction)
			{
				current += 1;
				count += current;
			}
			Console.WriteLine(current-1); //while 加N大於105的狀況時會停，若要小於105的值則為N-1


		}
	}
}
