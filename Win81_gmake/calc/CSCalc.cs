using System;
using System.Runtime.InteropServices;
namespace Calc
{
	public class Program
	{
		[DllImport(@"sum.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int sum(int a, int b);
		public static void Main()
		{
			int a = 2;
			int b = 3;
			int c = sum(a, b);
			Console.WriteLine("{0}*{1}={2}", a, b, c);
			Console.ReadLine();
		}
	}
}
