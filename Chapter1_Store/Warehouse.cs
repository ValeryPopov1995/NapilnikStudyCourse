using System;

namespace NapilnikStudyCourse.Chapter1_Store
{
	public class Warehouse
	{
		private GoodsDictionary _goods = new GoodsDictionary();
		
		public void Delieve(Good good, int count)
		{
			if (good == null)
				throw new ArgumentNullException();
			if (count < 1)
				throw new ArgumentOutOfRangeException();

			_goods.Add(good, count);
		}
		
		public void ShowAvailableGoods()
		{
			Console.WriteLine();
			Console.WriteLine("Warehouse available goods:");
			_goods.ShowGoodsInConsole();
			Console.WriteLine();
		}
		
		public bool HasRequestingGoods(Good good, int count)
		{
			if (good == null) throw new ArgumentNullException();
			
			if (_goods.CheckGood(good, count)) return true;
			return false;
		}
	}
}
