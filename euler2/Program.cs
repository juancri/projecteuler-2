using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
	public static void Main ()
	{
		var res = Fib ()
			.TakeWhile (x => x <= 4000000)
			.Where (x => (x & 1) == 0)
			.Sum ();
		Console.WriteLine (res);
	}

	private static IEnumerable <int> Fib ()
	{
		var old1 = 0;
		var old2 = 1;
		while (true)
		{
			var current = old1 + old2;
			old1 = old2;
			yield return (old2 = current);
		}
	}
}
