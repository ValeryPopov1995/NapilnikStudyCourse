using System.Collections;
using System.Collections.Generic;
using System;

namespace NapilnikStudyCourse.Chapter1_Store
{
	public class GoodsDictionary
	{
		readonly Dictionary<Good, int> _goods = new Dictionary<Good, int>();
		
		public void Add(Good good, int count)
		{
			if (good == null) throw new ArgumentNullException();
			if (count <= 0) throw new ArgumentOutOfRangeException("ошибка в количестве добавляемых товаров");
			
			if (_goods.ContainsKey(good)) _goods[good] += count; // TODO check working ContainsKey
			else _goods.Add(good, count);
		}
		
		public void ShowGoodsInConsole()
		{
			if (_goods.Count == 0) Console.WriteLine("в списке нет товаров");
			else foreach(var e in _goods) Console.WriteLine(e.Key.Name + " " + e.Value);
		}
		
		public bool CheckGood(Good good, int count)
		{
			// TODO check working ContainsKey
			if (_goods.ContainsKey(good) && _goods[good] >= count) return true;
			return false;
		}
	}
}
