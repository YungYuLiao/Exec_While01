using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//使用 while , 在畫面顯示所有可以整除 300 的整數例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
			int current = 1;
			int restriction = 300;
			
			while (current <= restriction)
			{
				current++;
				if (restriction % current == 0)
				{
					Console.WriteLine(current);
				}
				continue;
			}
		}
	}
}
