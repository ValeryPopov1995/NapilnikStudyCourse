using System;
using System.Collections.Generic;

namespace NapilnikStudyCourse.Chapter1_Store
{
	public class Warehouse
	{
		GoodsDictionary _goods = new GoodsDictionary();
		
		public void Delieve(Good good, int count)
		{
			_goods.Add(good, count);
		}
		
		public void ShowAvailableGoods()
		{
			Console.WriteLine();
			Console.WriteLine("Warehouse available goods:");
			_goods.ShowGoodsInConsole();
			Console.WriteLine();
		}
		
		public bool IsHaveRequestingGoods(Good good, int count)
		{
			if (_goods.CheckGood(good, count)) return true;
			return false;
		}
	}
}
